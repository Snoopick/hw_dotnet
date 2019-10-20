using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hw_09 {
    public static class MyLogger {
        private const string LoggerLogPath = @"..\\..\\..\\logs\\";
        private static string lastError = string.Empty;
        private static int logType = 0;
        private static string defaultFileName = string.Empty;
        private static string defaultFilePath = string.Empty;

        public static string Log(int type = 0, string str = "") {
            string filePath = string.Empty;
            string date = DateTime.Now.ToString("dd.MM.yyy");

            if (type == 0) {
                MyLogger.Log(1, "No logger type");
                return MyLogger.lastError;
            }

            MyLogger.logType = type;

            if (str.Equals(string.Empty)) {
                MyLogger.Log(1, "Empty logger string");
                return MyLogger.lastError;
            }

            str = date + " - " + str;

            switch (type) {
                case 1:
                    MyLogger.lastError = str;
                    str += "\r\nBug trace\r\n";
                    break;
                case 2:
                    break;
                default:
                    MyLogger.Log(1, "Unknown type for log");
                    return MyLogger.lastError;
            }

            str += "\r\n";

            filePath = MyLogger.getFile();

            MyLogger.LogWriter(filePath, str);
            MyLogger.LogWriter(defaultFilePath, str);

            return string.Empty;
        }

        private static string getFile() {
            string date = DateTime.Now.ToString("dd.MM.yyy");
            MyLogger.defaultFileName = date + "_loggerLog";
            MyLogger.defaultFilePath = LoggerLogPath + defaultFileName;
            string fileName = string.Empty;

            fileName = MyLogger.PrepareFolder();

            return fileName;
        }

        private static string PrepareFolder(int newIndex = 0, bool needCreate = false) {
            if (needCreate) {
                File.Create(LoggerLogPath + defaultFileName + "_" + newIndex + ".txt");
            }

            List<string> files = Directory
                .GetFiles(LoggerLogPath, "*", SearchOption.AllDirectories)
                .ToList();
            int fileCount = files.Count();
            int fileIndex = 0;

            if (fileCount > 0) {
                fileIndex = fileCount - 1;
            }

            string filePath = LoggerLogPath + defaultFileName + "_" + fileIndex + ".txt";

            if (!File.Exists(filePath)) {
                File.Create(filePath);
                files.Add(defaultFileName + "_" + fileIndex + ".txt");
            }

            long fileSize = new FileInfo(filePath).Length;

            if (fileSize > (50 * 1024)) {
                PrepareFolder((fileIndex + 1), true);
            }

            return filePath;
        }

        private static void LogWriter(string filePath, string str) {
            FileInfo fileInf = new FileInfo(filePath);

            if (fileInf.Exists) {
                try {
                    using (StreamWriter sw = new StreamWriter(filePath, true, System.Text.Encoding.Default)) {
                        sw.WriteLine(str);
                    }
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}