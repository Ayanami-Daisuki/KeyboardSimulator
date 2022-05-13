namespace KeyboardSimulator
{
    public partial class GUI : Form
    {
        private Thread Executer = null;
        private int Time = 1000;
        public GUI()
        {
            InitializeComponent();
            DelayTime.Text = "1000";
        }
        private void Input_TextChanged(object sender, EventArgs e)
        {
            Keyboard.Text = Input.Text;
        }
        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���������������л���Ӣ�����뷨����������\n" +
                "\n\n" +
                "���������ģ��������룬��ģ���������ġ�\n" +
                "��� ��ճ��������ť�󣬽��ӳ�һ��ʱ�����ִ��ģ�����롣\n" +
                "\n" +
                "���⣬���ж�ճ��������ճ����������ʱǿ����ֹ�İ�ť��");
        }
        public static class Keyboard
        {
            private static bool simulateMode = false;
            private static int time = 1000;
            public static int Time
            {
                get => time;
                set => time = value;
            }
            public static bool SimulateMode
            {
                get => simulateMode;
                set => simulateMode = value;
            }
            private static string text = "";
            public static string Text
            {
                get => text;
                set => text = value;
            }
            public static void Simulator()
            {
                string KeyStream = "";
                string Temp = Text;
                for (int i = 0; i < Temp.Length; i++)
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
                            KeyStream += Temp[i];
                            break;
                    }
                }
                Thread.Sleep(Time);
                if (!SimulateMode)
                    SendKeys.SendWait(KeyStream);
                else
                {
                    Random Generator = new Random();
                    for (int i = 0; i < KeyStream.Length; i++)
                    {
                        for (int j = 0; j < Generator.Next(2, 6); j++)
                        {
                            if (i >= KeyStream.Length)
                                break;
                            SendKeys.SendWait("" + KeyStream[i]);
                            i++;
                        }
                        Thread.Sleep(Generator.Next(500, 1000));
                    }
                }
            }
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Keyboard.SimulateMode = SimulateMode.Checked;
            Keyboard.Time = Time;
            Executer = new Thread(new ThreadStart(Keyboard.Simulator));
            Executer.Start();
            while (Executer.IsAlive)
            {
                Application.DoEvents();
            }
            MessageBox.Show("ճ�����");
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            Start.Size = new Size(100, 30);
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            if (Executer != null)
                Executer.Abort();
        }
        private void DelayTime_TextChanged(object sender, EventArgs e)
        {
            if (DelayTime.Text.Length == 0) DelayTime.Text = "0";
            if ('0' > DelayTime.Text[DelayTime.Text.Length - 1] || DelayTime.Text[DelayTime.Text.Length - 1] > '9')
                DelayTime.Text = DelayTime.Text.Substring(0, DelayTime.Text.Length - 1);
            else
            {
                if (!int.TryParse(DelayTime.Text, out Time))
                    DelayTime.Text = "1000";
            }
        }
    }
}