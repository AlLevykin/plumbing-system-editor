using System;

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

            string tubes = Path.Combine(library, "Tubes");
            if (!Directory.Exists(tubes))
            {
                Directory.CreateDirectory(tubes);
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
    }
}
