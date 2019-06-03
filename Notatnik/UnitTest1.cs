using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.Factory;
using TestStack.White.InputDevices;
using TestStack.White.WindowsAPI;

namespace Notatnik
{
    [TestClass]
    public class UnitTest1
    {
        public Application app;
        const string notepad = ("C:\\Windows\\System32\\notepad.exe");

        [TestMethod]
        public void TestMethod1()
        {

            app = TestStack.White.Application.Launch(notepad);
            Window window = app.GetWindow("Bez tytułu — Notatnik", InitializeOption.NoCache);
            

            //wpisywanie ciagu znakow i zapis
            TextBox text1 = window.Get<TextBox>(SearchCriteria.ByAutomationId("15"));
            window.Keyboard.Enter("G");
            System.Threading.Thread.Sleep(100);

            window.Keyboard.Enter("R");
            System.Threading.Thread.Sleep(100);

            window.Keyboard.Enter("Z");
            System.Threading.Thread.Sleep(100);

            window.Keyboard.Enter("E");
            System.Threading.Thread.Sleep(100);

            window.Keyboard.Enter("G");
            System.Threading.Thread.Sleep(100);

            window.Keyboard.Enter("O");
            System.Threading.Thread.Sleep(100);

            window.Keyboard.Enter("R");
            System.Threading.Thread.Sleep(100);

            window.Keyboard.Enter("Z");
            System.Threading.Thread.Sleep(100);


            MenuBar menubar = window.MenuBar;
            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.CONTROL);
            window.Keyboard.Enter("S");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.CONTROL);

            TextBox textSave = window.Get<TextBox>(SearchCriteria.ByAutomationId("1001"));
            textSave.Text = "myk.txt";


            Button textSaveDesktop = window.Get<Button>(SearchCriteria.ByAutomationId("1"));
            textSaveDesktop.Click();

            //nadpisywanie
            Button textOverride = window.Get<Button>(SearchCriteria.ByAutomationId("CommandButton_6"));
            textOverride.Click();

            //sprawdzanie czy na dysku jest juz taki plik
            // Button textOverride = window.Get<Button>(SearchCriteria.ByAutomationId("CommandButton_6"));
            //textOverride.Click();

            //--------------------------------------------------------------------------------------------------------------------------------

            TextBox textStyleFont = window.Get<TextBox>(SearchCriteria.ByAutomationId("15"));
            textStyleFont.Text = " Szwed to pilny student informatyki";

            System.Threading.Thread.Sleep(500);


            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.ALT);
            window.Keyboard.Enter("M");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.ALT);
            System.Threading.Thread.Sleep(500);

            window.Keyboard.Enter("C");


            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.ALT);
            window.Keyboard.Enter("O");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.ALT);
            System.Threading.Thread.Sleep(500);

            TextBox textStyled = window.Get<TextBox>(SearchCriteria.ByAutomationId("1001"));
            textStyled.Text = "Cooper";

            Button textSaveStyle = window.Get<Button>(SearchCriteria.ByAutomationId("1"));
            textSaveStyle.Click();
            System.Threading.Thread.Sleep(500);

            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.CONTROL);
            window.Keyboard.Enter("S");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.CONTROL);

            System.Threading.Thread.Sleep(1000);


            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.CONTROL);
            window.Keyboard.Enter("A");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.CONTROL);
            System.Threading.Thread.Sleep(500);

            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.BACKSPACE);
            System.Threading.Thread.Sleep(100);
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.BACKSPACE);


            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.CONTROL);
            window.Keyboard.Enter("S");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.CONTROL);


            TextBox textCpp = window.Get<TextBox>(SearchCriteria.ByAutomationId("15"));
            textCpp.Text = "#include <iostream>";
            System.Threading.Thread.Sleep(400);
            textCpp.Text = "\nusing namespace std;";
            System.Threading.Thread.Sleep(400);
            textCpp.Text = "\nint main(){";
            System.Threading.Thread.Sleep(400);
            textCpp.Text = "\ncout <<\"Hello, World\";";
            System.Threading.Thread.Sleep(400);
            textCpp.Text = "\nreturn 0;";
            System.Threading.Thread.Sleep(400);
            textCpp.Text = "\n}";

            //zapis inne rozszerzenie

            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.ALT);
            window.Keyboard.Enter("P");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.ALT);
            System.Threading.Thread.Sleep(500);

            window.Keyboard.Enter("A");
            System.Threading.Thread.Sleep(100);


            TextBox textSaveCpp = window.Get<TextBox>(SearchCriteria.ByAutomationId("1001"));
           
            textSaveCpp.Text = "hello_world.cpp";

            Button buttonSaveCpp = window.Get<Button>(SearchCriteria.ByAutomationId("1"));
            buttonSaveCpp.Click();
            System.Threading.Thread.Sleep(200);

            Button textOverrideCpp = window.Get<Button>(SearchCriteria.ByAutomationId("CommandButton_6"));
            textOverrideCpp.Click();

            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.CONTROL);
            window.Keyboard.Enter("A");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.CONTROL);
            System.Threading.Thread.Sleep(500);

            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.BACKSPACE);
            System.Threading.Thread.Sleep(100);


            TextBox congratulations = window.Get<TextBox>(SearchCriteria.ByAutomationId("15"));
            congratulations.Text = "Gratulacje!! Twój program zostal zapisany";
            System.Threading.Thread.Sleep(200);

            /*zapisywanie do PDF

            //Button saveChanges = window.Get<Button>(SearchCriteria.ByAutomationId("CommandButton_7"));
            //saveChanges.Click();

            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.ALT);
            window.Keyboard.Enter("P");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.ALT);
            System.Threading.Thread.Sleep(300);

            window.Keyboard.Enter("D");
            System.Threading.Thread.Sleep(300);

            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.ALT);
            window.Keyboard.Enter("D");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.ALT);
            System.Threading.Thread.Sleep(300);


            Button textSavePDF = window.Get<Button>(SearchCriteria.ByAutomationId("Close"));
            textSavePDF.Click();
            System.Threading.Thread.Sleep(300);
            */

            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.CONTROL);
            window.Keyboard.Enter("F");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.CONTROL);
            System.Threading.Thread.Sleep(300);


            TextBox textFind = window.Get<TextBox>(SearchCriteria.ByAutomationId("1152"));
            textFind.Text = "Malwina";
            System.Threading.Thread.Sleep(1000);


            Button textFindButton = window.Get<Button>(SearchCriteria.ByAutomationId("1"));
            textFindButton.Click();
            System.Threading.Thread.Sleep(1500);

            Button textFindButtonClose = window.Get<Button>(SearchCriteria.ByAutomationId("2"));
            textFindButtonClose.Click();
            System.Threading.Thread.Sleep(1500);

            Button textFindButtonAbort = window.Get<Button>(SearchCriteria.ByAutomationId("2"));
            textFindButtonAbort.Click();
            System.Threading.Thread.Sleep(1500);


            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.CONTROL);
            window.Keyboard.Enter("O");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.CONTROL);
            System.Threading.Thread.Sleep(300);

            Button ifSave = window.Get<Button>(SearchCriteria.ByAutomationId("CommandButton_7"));
            ifSave.Click();
            System.Threading.Thread.Sleep(2000);

            TextBox textOpenFile = window.Get<TextBox>(SearchCriteria.ByAutomationId("1148"));
            textOpenFile.Text = "myk.txt";
            System.Threading.Thread.Sleep(300);


            Button textOpenFileButton = window.Get<Button>(SearchCriteria.ByAutomationId("1"));
            textOpenFileButton.Click();
            System.Threading.Thread.Sleep(3000);

            TextBox dataTest = window.Get<TextBox>(SearchCriteria.ByAutomationId("15"));
            dataTest.Text = "\n";
            System.Threading.Thread.Sleep(400);
            dataTest.Text = "Test zostal wykonany dnia: ";
            System.Threading.Thread.Sleep(200);

            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.CONTROL);
            window.Keyboard.Enter("S");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.CONTROL);
            System.Threading.Thread.Sleep(300);


            window.Keyboard.HoldKey(KeyboardInput.SpecialKeys.ALT);
            window.Keyboard.Enter("E");
            window.Keyboard.LeaveKey(KeyboardInput.SpecialKeys.ALT);
            System.Threading.Thread.Sleep(300);

            for (int i = 0; i < 8; i++)
            {
                window.Keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.DOWN);
                System.Threading.Thread.Sleep(500);
            }

            window.Keyboard.Enter("D");
            System.Threading.Thread.Sleep(2000);


            //1148
            Button exit = window.Get<Button>(SearchCriteria.ByAutomationId("Close"));
            exit.Click();

            System.Threading.Thread.Sleep(500);


            app.Close();


        }
    }
}
