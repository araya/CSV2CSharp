using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Double;

namespace CSV2CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = System.AppDomain.CurrentDomain.BaseDirectory + @"ExportCSV\";
            DirectoryInfo folder = new DirectoryInfo(url);
            foreach (var item in folder.GetFiles("*.csv"))
            {
                string fileName = item.Name;
                CsvFileToCSharpClass(url + fileName);
            }
        }

        public static void CsvFileToCSharpClass(string filePath)
        {
            //读取所有的数据
            string[] lines = File.ReadAllLines(filePath);

            //类型
            string[] typeName = lines[0].Split(',').Select(str => str.Trim()).ToArray();
            //属性
            string[] variableName = lines[1].Split(',').Select(str => str.Trim()).ToArray();
            //注释
//            string[] noteStr = lines[2].Split(',').Select(str => str.Trim()).ToArray();

            //类的名字
            string className = Path.GetFileNameWithoutExtension(filePath);
            //类的结构
            string code = "using UnityEngine;\nusing System.Collections;\nusing System.Collections.Generic;\n\n";
            code = "";
            code += $"//\n// {className}\n//\n";
            code += $"public class {className}Info {{ \n\n";

            for (int i = 0; i < typeName.Length; i++)
            {
                if (string.IsNullOrEmpty(typeName[i]))
                {
                    continue;
                }
                string type;
                type = TryParse(@variableName[i], NumberStyles.Integer, null, out var _a) ? "int" : "string";
                code += String.Format("\t//{0}\n", variableName[i]);
                code += $"\tpublic {type} {typeName[i]} {{ get; set; }}\n\n";
            }

            code += "}\n";

            string url = System.AppDomain.CurrentDomain.BaseDirectory + @"CSharp\";
            string CSharpFile = $"{url}{className}Info.cs";

            File.WriteAllText(CSharpFile, code);
        }

        
    }
}
