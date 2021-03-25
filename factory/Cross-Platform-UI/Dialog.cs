using System;

namespace Factory {
    public abstract class Dialog {
        public abstract Button createButton();
        Action closeDialog = new Action(Close);
        
        public void Render() {
            Button okButton = createButton();
            okButton.OnClick(closeDialog);
            okButton.Render();
        }

        public static void Close() {
            Console.WriteLine("Closed the dialog box");
        }
    }

    public class WindowsDialog : Dialog {
        public override Button createButton()
        {
            return new WindowsButton();
        }
    }

    public class WebDialog : Dialog {
        public override Button createButton()
        {
            return new WebButton();
        }
    }
    
}