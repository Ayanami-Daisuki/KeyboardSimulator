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
            MessageBox.Show("���������ģ��������룬��ģ���������ġ�\n" +
                "�����һ���Լ�������Ҫճ�������ݵ��ı����ڡ�\n" +
                "��� ��ճ������ ��ť�󣬽��ӳ�����ִ��ģ�����롣\n" +
                "���������������л���Ӣ�����뷨����������");
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