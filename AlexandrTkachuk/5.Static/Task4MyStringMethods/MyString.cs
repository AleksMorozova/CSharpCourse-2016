using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4MyStringMethods
{
    static class MyString
    {
        public static string Replace(string line, string oldLine, string newLine)
        {
            List<int> listOfIndexes = MyString.FoundIndexesOfOldLines(line, oldLine);
            string result = "";
            for (int i = 0; i < listOfIndexes.Count; i++)
            {          
                string lineBegining = MyString.Substring(line, 1, MyString.IndexOf(line, oldLine)-1);
                string lineEnding = "";
                for (int j = listOfIndexes[i] + oldLine.Length ; j <= line.Length; j++)
                {
                    lineEnding += line[j-1];
                }               
                    result += lineBegining + newLine;
                    line = lineEnding;
                if( i == listOfIndexes.Count-1)
                {
                    result += lineEnding;
                }
            }
            return result;
        }

        public static string Substring(string enteredLine, int index, int length)
        {
            string resultLine = "";
            for (int i = index-1, j = 0; j < length; i++, j++)
            {
                resultLine += enteredLine[i];
            }
            return resultLine;
        }

        public static int IndexOf(string line, string lineToFind)
        {
            char firstCharOfLineToFind = lineToFind[0];
            for (int i = 0; i < line.Length; i++)
            {                
                if(line[i] == firstCharOfLineToFind)
                {
                    for (int j = 0; j < lineToFind.Length; j++)
                    {
                        if (line[i+j] != lineToFind[j])
                        {
                            break;
                        }
                        if (j == lineToFind.Length - 1)
                        {
                            return i+1;
                        }
                    }
                }
            }
            return -1;
        }      


        static List<int> FoundIndexesOfOldLines(string line, string oldLine)
        { 
            List<int> listOfIndexes = new List<int>();
            string temporaryLine = line;
            int index = 0;
            int intTemp;
            do
            {
                intTemp = MyString.IndexOf(temporaryLine, oldLine);
                if (intTemp != -1)
                {                   
                    listOfIndexes.Add(intTemp);
                    string stringTemp = "";
                    for (int i = intTemp + oldLine.Length - 1; i < temporaryLine.Length; i++)
                    {
                        stringTemp += temporaryLine[i];                       
                    }
                    temporaryLine = stringTemp;
                }
            } while (intTemp != -1);
            return listOfIndexes;
        }


    }
}
