using System;

namespace Factory {
    class Application {
        private Dialog dialog;
        public Application() {
            this.dialog = null;        
        }

        public void Init(string config) {
            if (config == "win") this.dialog = new WindowsDialog();
            else if (config == "web") this.dialog = new WebDialog();
            else throw (new NotSupportedException("Unknown OS"));
        }

        public void Run(string config) {
            try {
                this.Init(config);
            }
            catch(NotSupportedException e) {
                Console.WriteLine(e.Message);
                return;
            }
            this.dialog.Render();
        }
    }

    public class NotSupportedException : Exception {
        public NotSupportedException(string message): base(message) {}
    }
}