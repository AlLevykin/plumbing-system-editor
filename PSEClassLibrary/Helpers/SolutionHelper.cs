using System.Text.Encodings.Web;
using System.Text.Json;

namespace PSEClassLibrary.Helpers
{
    public static class SolutionHelper
    {
        private static void CheckPath(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new ArgumentException(string.Format("Путь {0} задан неверно", path), nameof(path));
            }

            string projects = Path.Combine(path, "Projects");
            if (!Directory.Exists(projects))
            {
                Directory.CreateDirectory(projects);
            }

            string library = Path.Combine(path, "Library");
            if (!Directory.Exists(library))
            {
                Directory.CreateDirectory(library);
            }

            string pipes = Path.Combine(library, "Pipes");
            if (!Directory.Exists(pipes))
            {
                Directory.CreateDirectory(pipes);
            }

            string fittings = Path.Combine(library, "Fittings");
            if (!Directory.Exists(fittings))
            {
                Directory.CreateDirectory(fittings);
            }

            string modules = Path.Combine(library, "Modules");
            if (!Directory.Exists(modules))
            {
                Directory.CreateDirectory(modules);
            }
        }

        public static Solution Open(string path)
        {
            CheckPath(path);
            Solution s = new(path);
            return s;
        }

        public static Pipe NewPipe(Solution s, string index)
        {
            string path = Path.Combine(s.PipesPath, index + ".pipe");
            if (File.Exists(path))
            {
                throw new ArgumentException(string.Format("Тип труб {0} уже имеется", index));
            }

            Pipe pipe = new();
            pipe.Index = index;
            string jsonString = JsonSerializer.Serialize(pipe, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
            File.WriteAllText(path, jsonString);
            return pipe;
        }

        public static Fitting NewFitting(Solution s, string index, string model)
        {
            string path = Path.Combine(s.FittingsPath, index, index + ".fitting");
            if (File.Exists(path))
            {
                throw new ArgumentException(string.Format("Тип фиттингов {0} уже имеется", index));
            }

            string dir = Path.GetDirectoryName(path) ?? "";
            if (String.IsNullOrEmpty(dir!))
            {
                throw new ArgumentException(string.Format("Имя папки не задано"));
            }
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            Fitting fitting = new();
            fitting.Index = index;
            fitting.Model = Path.GetFileName(model);
            string jsonString = JsonSerializer.Serialize(fitting, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
            File.WriteAllText(path, jsonString);
            File.Copy(model, Path.Combine(s.FittingsPath, index, fitting.Model));
            return fitting;
        }

        public static Module NewModule(Solution s, string index, string drawing)
        {
            string path = Path.Combine(s.ModulesPath, index, index + ".module");
            if (File.Exists(path))
            {
                throw new ArgumentException(string.Format("Тип СТУ {0} уже имеется", index));
            }

            string dir = Path.GetDirectoryName(path) ?? "";
            if (String.IsNullOrEmpty(dir!)) 
            {
                throw new ArgumentException(string.Format("Имя папки не задано"));
            }
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            Module module = new();
            module.Index = index;
            module.Drawing = Path.GetFileName(drawing);
            string jsonString = JsonSerializer.Serialize(module, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
            File.WriteAllText(path, jsonString);
            File.Copy(drawing, Path.Combine(s.ModulesPath, index, module.Drawing));
            return module;
        }
    }
}
