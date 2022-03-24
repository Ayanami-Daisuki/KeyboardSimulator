namespace KeyboardSimulator
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            Keyboard.Text = Input.Text;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本软件用于模拟键盘输入，可模拟输入中文。\n" +
                "你可以一次性键入所有要粘贴的内容到文本框内。\n" +
                "点击 “粘贴！” 按钮后，将延迟三秒执行模拟输入。\n" +
                "！！！！！请先切换成英文输入法！！！！！");
        }

        public static class Keyboard
        {
            private static string text = "";
            public static string Text
            {
                get => text;
                set => text = value;
            }
            public static void Simulator()
            {
                string KeyStream = "";
                for (int i = 0; i < Text.Length; i++)
                {
                    switch (Text[i])
                    {
                        case '+':
                            KeyStream += "{ADD}";
                            break;
                        case '-':
                            KeyStream += "{SUBTRACT}";
                            break;
                        case '*':
                            KeyStream += "{MULTIPLY}";
                            break;
                        case '/':
                            KeyStream += "{DIVIDE}";
                            break;
                        case '(':
                            KeyStream += "{(}";
                            break;
                        case ')':
                            KeyStream += "{)}";
                            break;
                        default:
                            KeyStream += Text[i];
                            break;
                    }
                }
                Thread.Sleep(1000);
                SendKeys.SendWait(KeyStream);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Thread Executer = new(new ThreadStart(Keyboard.Simulator));
            Executer.Start();
        }


    }
}