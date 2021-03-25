using System;

namespace Factory {
    public interface Button {
        void Render();
        void OnClick(Action f);
        void Click();
    }

    public class WindowsButton : Button {
        private Action _onClickAction;

        public void Render() {
            Console.WriteLine("You're seeing a windows button");
        }

        public void OnClick(Action f) {
            _onClickAction = f;
        }

        public void Click() {
            _onClickAction();
        }
    }

    public class WebButton : Button {
        private Action _onClickAction;

        public void Render() {
            Console.WriteLine("You're seeing an HTML button");
        }

        public void OnClick(Action f) {
            _onClickAction = f;
        }

        public void Click() {
            _onClickAction();
        }
    }
}