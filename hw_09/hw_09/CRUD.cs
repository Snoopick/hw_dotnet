using System;
using System.Collections.Generic;
using System.Text;

namespace hw_09 {
    public static class CRUD {
        //private static string[] dataArray;
        private static Dictionary<string, string> dataArray = new Dictionary<string, string> { };

        public static Dictionary<string, string> GetAll() {
            return CRUD.dataArray;
        }

        public static string GetByID(string key) {
            if (key.Equals(string.Empty)) {
                MyLogger.Log(1, "No key");
                return "No key";
            }

            return CRUD.dataArray[key];
        }

        public static bool Save(Dictionary<string, string> dataArray) {
            CRUD.dataArray = dataArray;

            return true;
        }

        public static bool Update(string key, string dataArray) {
            if (key.Equals(string.Empty)) {
                return false;
            }

            CRUD.dataArray[key] = dataArray;

            return true;
        }

        public static bool Delete(string key) {
            if (key.Equals(string.Empty)) {
                return false;
            }

            CRUD.dataArray[key] = string.Empty;

            return true;
        }
    }
}