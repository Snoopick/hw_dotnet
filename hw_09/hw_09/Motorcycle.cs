using System;
using System.Collections.Generic;
using System.Text;

namespace hw_09 {
    class Motorcycle {
        private Dictionary<string, string> data = new Dictionary<string, string> { };
        public Motorcycle() {
            this.data.Add("VIN", "VIN-CODE-13412-ASDAS");
            this.data.Add("WEIGHT", "200");
            this.data.Add("ENGINE", "2000");

            Console.WriteLine("Get data from array:");
            this.GetData();

            Console.WriteLine("Save data");
            this.SaveData(this.data);

            Console.WriteLine("Update WEIGHT to 2200");
            this.UpdateData("WEIGHT", "2200");

            Console.WriteLine("Get data by key WEIGHT");
            this.GetData("WEIGHT");

            Console.WriteLine("Delete data by key ENGINE");
            this.DeleteData("ENGINE");

            Console.WriteLine("Get result data");
            this.GetData();
        }

        void SaveData(Dictionary<string, string> data) {
            MyLogger.Log(2, "Save data action");
            if (data.Equals(string.Empty)) {
                MyLogger.Log(1, "Empty data");
            }

            if (!CRUD.Save(data)) {
                MyLogger.Log(1, "Data not Saved");
            }
        }

        void GetData(string key = "") {
            MyLogger.Log(2, "Get data action");


            if (key != string.Empty) {
                MyLogger.Log(2, "Get data by ID action");
                string resultArray = CRUD.GetByID(key);
                Console.WriteLine("Key: " + key + " data: " + resultArray);
            } else {
                var resultArray = CRUD.GetAll();
                foreach (var value in resultArray) {
                    Console.WriteLine(value);
                }
            }
        }

        void UpdateData(string key, string data) {
            MyLogger.Log(2, "Update data action");

            if (key.Equals(string.Empty)) {
                MyLogger.Log(1, "Key is empty");
            }

            if (!CRUD.Update(key, data)) {
                MyLogger.Log(1, "Data not updated");
            }
        }

        void DeleteData(string key) {
            MyLogger.Log(2, "Delete data action");

            if (key.Equals(string.Empty)) {
                MyLogger.Log(1, "Key is empty");
            }

            if (!CRUD.Delete(key)) {
                MyLogger.Log(1, "Data not deleted");
            }
        }
    }
}