using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dptools
{
    public class MenuBuilder
    {
        #region field initialization
        private StringBuilder sb;
        private const string LongBlock = "##############################################################\n";
        private const string TwoColumnBlock = "########                                              ########\n";
        private const string SingleColumnBlock = "########";
        private List<String> _introList; //also implement public accessors with getters for display

        
        #endregion

        #region constructor
        public MenuBuilder()
        {

        }

        public MenuBuilder(string fileName)
        {
            //TODO: Implement FileRead private method
        }
        


        #endregion

        #region public methods
        public void DisplayTestMenu()
        {
            string OpeningStatement = Statements("open");
            string ClosingStatement = Statements("close");
            Console.WriteLine(OpeningStatement);
            Console.WriteLine("{0}  Welcome to (ProgramName)!!!                 {0}", SingleColumnBlock);
            Console.WriteLine("{0}                          By: (Author)        {0}", SingleColumnBlock); 
            Console.WriteLine(ClosingStatement);
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(OpeningStatement);
            Console.WriteLine("{0} (Instructions)								  {0}", SingleColumnBlock);
            Console.WriteLine(ClosingStatement);
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(OpeningStatement);
            Console.WriteLine("{0} (Menu)										  {0}", SingleColumnBlock);
            Console.WriteLine(ClosingStatement);

        }
        #endregion

        #region private methods
        //1. Whole file read into string array (each line)
        private void FileRead(string fileName)
        {
            string [] fileContent = System.IO.File.ReadAllLines(fileName);
            int programIndex = Array.IndexOf(fileContent, "@@PROGRAM NAME:@@");
            int authorIndex = Array.IndexOf(fileContent, "@@AUTHOR:@@");
            int instructionIndex = Array.IndexOf(fileContent, "@@INSTRUCTIONS:@@");
            int menuIndex = Array.IndexOf(fileContent, "@@MENU:@@");
            if (authorIndex - programIndex == 2 && fileContent[1].Length < 33)
                // programIndex should be 0, authorIndex should be 2, and the filename should be under 33 characters
                IntroBuild(fileContent, programIndex, authorIndex);
            else
                throw new ArgumentException("More than one line for program name or name too long");



        }

        // Void because it will put the data in the declared _introList variable
        private void IntroBuild(string [] content, int startIndex, int endIndex)
        {
            int whitespace = 32 - content[1].Length;
            string spaces = new String(' ', whitespace);
            // YOU ARE HERE
        }

        // To construct the invariant parts of the menu.
        private string Statements(string openOrClose)
        {
            switch (openOrClose)
            {
                case "open":
                    sb.Clear();
                    return sb.AppendFormat("{0}{0}{1}", LongBlock, TwoColumnBlock).ToString();
                case "close":
                    sb.Clear();
                    return sb.AppendFormat("{1}{0}{0}", LongBlock, TwoColumnBlock).ToString();
                default:
                    throw new ArgumentOutOfRangeException("Valid Parameters are 'open' and 'close'");
            }
        }
        #endregion
    }
}
