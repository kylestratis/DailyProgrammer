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
        private List<String> _introList; //also implement public properties with getters for display

        
        #endregion

        #region constructor
        public MenuBuilder()
        {

        }

        public MenuBuilder(string fileName)
        {
            //TODO: Implement FileRead private method, and then the *BUILD private methods,
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
            if (authorIndex - programIndex == 2 && fileContent[programIndex + 1].Length < 33 && fileContent[authorIndex + 1].Length < 37)
                IntroBuild(fileContent, programIndex, authorIndex);
            else
                throw new ArgumentException("More than one line for program name or name too long");



        }

        // Void because it will put the data in the declared _introList variable
        private void IntroBuild(string [] content, int startIndex, int endIndex)
        {
            int nameWhitespace = 32 - content[startIndex + 1].Length;
            int authorWhitespace = 40 - content[endIndex + 1].Length;
            string nameSpaces = new String(' ', nameWhitespace);
            string authorSpaces = new String(' ', authorWhitespace);
            StringBuilder introSB = new StringBuilder();

            string programLine = introSB.AppendFormat("{0} Welcome to {1}{2} {0}", SingleColumnBlock, content[startIndex + 1], nameSpaces).ToString();
            introSB.Clear();
            string authorLine = introSB.AppendFormat("{0} {1} By: {2} {0}", SingleColumnBlock, authorSpaces, content[endIndex + 1]).ToString();

            if (_introList.Any())
            {
                _introList.Clear();
            }
            _introList.Add(Statements("open"));
            _introList.Add(programLine);
            _introList.Add(authorLine);
            _introList.Add(Statements("close"));
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
