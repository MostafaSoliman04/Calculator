namespace calculatortest
{
    using System.CodeDom.Compiler;
    using System.Security.Cryptography.X509Certificates;
    using System.Xml.Serialization;

    public partial class Form1 : Form
    {
        //Operation Button
        Button add = new Button();
        Button sub = new Button();
        Button mult = new Button();
        Button divide = new Button();
        Button modulo = new Button();
        Button equal = new Button();


        //Num Button
        Button zero = new Button();
        Button one = new Button();
        Button two = new Button();
        Button three = new Button();
        Button four = new Button();
        Button five = new Button();
        Button six = new Button();
        Button seven = new Button();
        Button eight = new Button();
        Button nine = new Button();

        //Clear Calculator
        Button delet = new Button();
        Button clear = new Button();


        //output box
        TextBox output = new TextBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(500, 800);
            this.Text = "Calculator";
            this.Controls.Add(zero);
            this.Controls.Add(one);
            this.Controls.Add(two);
            this.Controls.Add(three);
            this.Controls.Add(four);
            this.Controls.Add(five);
            this.Controls.Add(six);
            this.Controls.Add(seven);
            this.Controls.Add(eight);
            this.Controls.Add(nine);
            this.Controls.Add(add);
            this.Controls.Add(sub);
            this.Controls.Add(mult);
            this.Controls.Add(divide);
            this.Controls.Add(modulo);
            this.Controls.Add(delet);
            this.Controls.Add(clear);
            this.Controls.Add(output);
            this.Controls.Add(equal);





            zero.Text = "0";
            zero.Location = new Point(20, 680);
            zero.Size = new Size(220, 60);
            zero.Click += new EventHandler(zero_btn);



            one.Location = new Point(20, 560);
            one.Size = new Size(100, 60);
            one.Text = "1";
            one.Click += new EventHandler(one_btn);

            two.Location = new Point(140, 560);
            two.Size = new Size(100, 60);
            two.Text = "2";
            two.Click += new EventHandler(two_btn);

            three.Location = new Point(260, 560);
            three.Size = new Size(100, 60);
            three.Text = "3";
            three.Click += new EventHandler(three_btn);

            four.Location = new Point(20, 440);
            four.Size = new Size(100, 60);
            four.Text = "4";
            four.Click += new EventHandler(four_btn);

            five.Location = new Point(140, 440);
            five.Size = new Size(100, 60);
            five.Text = "5";
            five.Click += new EventHandler(five_btn);

            six.Location = new Point(260, 440);
            six.Size = new Size(100, 60);
            six.Text = "6";
            six.Click += new EventHandler(six_btn);

            seven.Location = new Point(20, 320);
            seven.Size = new Size(100, 60);
            seven.Text = "7";
            seven.Click += new EventHandler(seven_btn);

            eight.Location = new Point(140, 320);
            eight.Size = new Size(100, 60);
            eight.Text = "8";
            eight.Click += new EventHandler(eight_btn);

            nine.Location = new Point(260, 320);
            nine.Size = new Size(100, 60);
            nine.Text = "9";
            nine.Click += new EventHandler(nine_btn);

            equal.Location = new Point(260, 680);
            equal.Size = new Size(220, 60);
            equal.Text = "=";
            equal.Click += new EventHandler(equal_btn);

            modulo.Location = new Point(260, 200);
            modulo.Size = new Size(100, 60);
            modulo.Text = "%";
            modulo.Click += new EventHandler(mod_btn);

            add.Location = new Point(380, 560);
            add.Size = new Size(100, 60);
            add.Text = "+";
            add.Click += new EventHandler(add_btn);

            sub.Location = new Point(380, 440);
            sub.Size = new Size(100, 60);
            sub.Text = "-";
            sub.Click += new EventHandler(sub_btn);

            mult.Location = new Point(380, 320);
            mult.Size = new Size(100, 60);
            mult.Text = "x";
            mult.Click += new EventHandler(multi_btn);

            divide.Location = new Point(380, 200);
            divide.Size = new Size(100, 60);
            divide.Text = "/";
            divide.Click += new EventHandler(divide_btn);

            delet.Location = new Point(140, 200);
            delet.Size = new Size(100, 60);
            delet.Text = "Delet";
            delet.Click += new EventHandler(delet_btn);

            clear.Location = new Point(20, 200);
            clear.Size = new Size(100, 60);
            clear.Text = "Clear";
            clear.Click += new EventHandler(clear_btn);

            output.Location = new Point(20, 20);
            output.Size = new Size(450, 400);
            output.ReadOnly = true;
            //output.RightToLeft = RightToLeft.Yes;
            //output.Click += new EventHandler(output_btn);
        }

        linkedlist n = new linkedlist();

        private void zero_btn(object sender, EventArgs e)
        {
            n.insertatend("0");
            output.Text = output.Text + "0";
        }

        private void one_btn(object sender, EventArgs e)
        {
            n.insertatend("1");
            output.Text = output.Text + "1";
        }
        private void two_btn(object sender, EventArgs e)
        {
            n.insertatend("2");
            output.Text = output.Text + "2";
        }
        private void three_btn(object sender, EventArgs e)
        {
            n.insertatend("3");
            output.Text = output.Text + "3";
        }
        private void four_btn(object sender, EventArgs e)
        {
            n.insertatend("4");
            output.Text = output.Text + "4";
        }
        private void five_btn(object sender, EventArgs e)
        {
            n.insertatend("5");
            output.Text = output.Text + "5";
        }
        private void six_btn(object sender, EventArgs e)
        {
            n.insertatend("6");
            output.Text = output.Text + "6";
        }
        private void seven_btn(object sender, EventArgs e)
        {
            n.insertatend("7");
            output.Text = output.Text + "7";
        }
        private void eight_btn(object sender, EventArgs e)
        {
            n.insertatend("8");
            output.Text = output.Text + "8";
        }
        private void nine_btn(object sender, EventArgs e)
        {
            n.insertatend("9");
            output.Text = output.Text + "9";
        }
        private void equal_btn(object sender, EventArgs e)
        {
            string x = n.result();
            if (x == "error")
            {
                output.Text = x;
            }
            else
            {
                output.Text = x;
            }


        }
        private void mod_btn(object sender, EventArgs e)
        {
            n.insertatend("%");
            output.Text = output.Text + "%";
        }
        private void add_btn(object sender, EventArgs e)
        {
            n.insertatend("+");
            output.Text = output.Text + "+";
        }
        private void sub_btn(object sender, EventArgs e)
        {
            n.insertatend("-");
            output.Text = output.Text + "-";
        }
        private void multi_btn(object sender, EventArgs e)
        {
            n.insertatend("*");
            output.Text = output.Text + "x";
        }
        private void divide_btn(object sender, EventArgs e)
        {
            n.insertatend("/");
            output.Text = output.Text + "/";
        }
        private void delet_btn(object sender, EventArgs e)
        {
            n.deletNode();
            if (output.Text.Length > 0)
            {
                output.Text = output.Text.Substring(0, output.Text.Length - 1);
            }

        }
        private void clear_btn(object sender, EventArgs e)
        {
            n.clearNodes();
            n.Clearsinlelinkedlist();
            output.Text = string.Empty;

        }

        class Nodesingle
        {
            public string datasingle;
            public Nodesingle nextsingle;
        }
        class Node
        {
            public string data;
            public Node next;
            public Node prev;
        }
        class linkedlist
        {
            Node head;
            Nodesingle headsingle;
            public void addendsinglelinkedlist(string data)
            {
                Nodesingle temp = new Nodesingle();
                temp.datasingle = data;
                if (headsingle == null)
                {
                    headsingle = temp;
                    temp.nextsingle = null;
                }
                else
                {
                    Nodesingle p = headsingle;
                    while (p.nextsingle != null)
                    {
                        p = p.nextsingle;
                    }
                    p.nextsingle = temp;
                    temp.nextsingle = null;
                }
            }
            public void Clearsingle()
            {
                headsingle = null;
            }
            public void printsinglelinkedlist()
            {
                Nodesingle p = headsingle;
                while (p != null)
                {
                    Console.WriteLine(p.datasingle);
                    p = p.nextsingle;
                }
            }
            public void criatdoublelinkedfromsingle()
            {
                clearNodes();
                Nodesingle p = headsingle;
                while (p != null)
                {
                    insertatend(p.datasingle);
                    p = p.nextsingle;
                }
            }
            public void Clearsinlelinkedlist()
            {
                headsingle = null;
            }










            public void insertatend(string data)
            {
                Node temp = new Node();
                temp.data = data;
                if (head == null)
                {
                    head = temp;
                    temp.next = null;
                    temp.prev = null;
                    return;
                }
                Node p = head;
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = temp;
                temp.prev = p;
                temp.next = null;
            }
            public void deletNode()
            {
                Node p = head;
                if (p.next == null)
                {
                    head = null;
                    p = null;
                    return;
                }
                while (p.next.next != null)
                    p = p.next;
                p.next.prev = null;
                p.next = null;

            }
            public void clearNodes()
            {
                head = null;
            }
            public int count()
            {
                Node p = head;
                int count = 0;
                while (p != null)
                {

                    if (p.data == "+" || p.data == "-" || p.data == "*" || p.data == "/" || p.data == "%")
                    {
                        //if (p.next.data == "-")
                        //{
                        //    p = p.next;
                        //}
                        count++;
                    }
                    p = p.next;

                }
                return count;
            }
            public string[] arr;
            public void creatarray()
            {
                arr = new string[(count() * 2) + 1];
                string str = "";
                int x = 0;
                Node p = head;
                while (p != null)
                {
                    if (p.data == "+" || p.data == "*" || p.data == "-" || p.data == "/" || p.data == "%")
                    {
                        arr[x] = str;
                        x++;
                        str = "";
                        arr[x] = p.data;
                        x++;
                    }
                    else
                    {
                        str = str + p.data;
                    }
                    p = p.next;
                }
                arr[x] = str;
            }


            public void Creatlist()
            {
                creatarray();
                clearNodes();
                for (int i = 0; i < arr.Length; i++)
                {
                    insertatend(arr[i]);
                }
            }
            public void print()
            {
                Node p = head;
                while (p != null)
                {
                    Console.WriteLine(p.data);
                    p = p.next;
                }
            }
            public string result()
            {
                Clearsingle();
                Creatlist();
                double r = 0;
                Node p = head.next;
                Node x = new Node();
                while (p != null)
                {

                    if (p.data == "*" || p.data == "/" || p.data == "%")
                    {
                        if (p.data == "*")
                        {
                            if (head.next == p)
                            {
                                r = double.Parse(p.prev.data) * double.Parse(p.next.data);
                                x.data = r.ToString();
                                x.next = p.next.next;
                                x.prev = null;
                                if (x.next != null)
                                {
                                    p.next.next.prev = x;
                                    p.next.next = null;
                                }
                                p = x.next;
                                head = x;
                            }
                            else
                            {
                                if (p.next.next == null)
                                {
                                    r = double.Parse(p.prev.data) * double.Parse(p.next.data);
                                    x.data = r.ToString();
                                    x.next = null;
                                    x.prev = p.prev.prev;
                                    p.prev.prev.next = x;
                                    p.prev.prev = null;
                                    p = x.next;
                                }
                                else
                                {
                                    r = double.Parse(p.prev.data) * double.Parse(p.next.data);
                                    x.data = r.ToString();
                                    x.next = p.next.next;
                                    x.prev = p.prev.prev;
                                    p.prev.prev.next = x;
                                    p.prev.prev = null;
                                    p.next.next.prev = x;
                                    p.next.next = null;
                                    p = x.next;

                                }
                            }
                            continue;
                        }
                        if (p.data == "/")
                        {
                            if (p.next.data == "0")
                            {
                                return "error";
                            }
                            if (head.next == p)
                            {
                                r = double.Parse(p.prev.data) / double.Parse(p.next.data);
                                x.data = r.ToString();
                                x.next = p.next.next;
                                x.prev = null;
                                if (x.next != null)
                                {
                                    p.next.next.prev = x;
                                    p.next.next = null;
                                  }
                                p = x.next;
                                head = x;
                            }
                            else
                            {
                                if (p.next.next == null)
                                {
                                    r = double.Parse(p.prev.data) / double.Parse(p.next.data);
                                    x.data = r.ToString();
                                    x.next = null;
                                    x.prev = p.prev.prev;
                                    p.prev.prev.next = x;
                                    p.prev.prev = null;
                                    p = x.next;
                                }
                                else
                                {
                                    r = double.Parse(p.prev.data) / double.Parse(p.next.data);
                                    x.data = r.ToString();
                                    x.next = p.next.next;
                                    x.prev = p.prev.prev;
                                    p.prev.prev.next = x;
                                    p.prev.prev = null;
                                    p.next.next.prev = x;
                                    p.next.next = null;
                                    p = x.next;

                                }
                            }
                            continue;
                        }
                        if (p.data == "%")
                        {
                            if (double.Parse(p.next.data) > double.Parse(p.prev.data))
                            {
                                return "error";
                            }
                            if (head.next == p)
                            {
                                r = double.Parse(p.prev.data) % double.Parse(p.next.data);
                                x.data = r.ToString();
                                x.next = p.next.next;
                                x.prev = null;
                                if (x.next != null)
                                {
                                    p.next.next.prev = x;
                                    p.next.next = null;
                                }
                                p = x.next;
                                head = x;
                            }
                            else
                            {
                                if (p.next.next == null)
                                {
                                    r = double.Parse(p.prev.data) % double.Parse(p.next.data);
                                    x.data = r.ToString();
                                    x.next = null;
                                    x.prev = p.prev.prev;
                                    p.prev.prev.next = x;
                                    p.prev.prev = null;
                                    p = x.next;
                                }
                                else
                                {
                                    r = double.Parse(p.prev.data) % double.Parse(p.next.data);
                                    x.data = r.ToString();
                                    x.next = p.next.next;
                                    x.prev = p.prev.prev;
                                    p.prev.prev.next = x;
                                    p.prev.prev = null;
                                    p.next.next.prev = x;
                                    p.next.next = null;
                                    p = x.next;

                                }
                            }
                            continue;
                        }
                    }
                    if (p.data == "+" || p.data == "-")
                    {
                        addendsinglelinkedlist(p.prev.data);
                        addendsinglelinkedlist(p.data);
                    }
                    
                    p = p.next.next;

                }
                p = head;
                while (p.next != null)
                {
                    p = p.next;
                }
                addendsinglelinkedlist(p.data);
                criatdoublelinkedfromsingle();
                p = head.next;
                while (p != null)
                {
                    if (p.data == "+" || p.data == "-")
                    {
                        if (p.data == "+")
                        {
                            if (head.next == p)
                            {
                                r = double.Parse(p.prev.data) + double.Parse(p.next.data);
                                x.data = r.ToString();
                                x.next = p.next.next;
                                x.prev = null;
                                if (x.next != null)
                                {
                                    p.next.next.prev = x;
                                    p.next.next = null;
                                }
                                p = x.next;
                                head = x;
                            }
                            else
                            {
                                if (p.next.next == null)
                                {
                                    r = double.Parse(p.prev.data) + double.Parse(p.next.data);
                                    x.data = r.ToString();
                                    x.next = null;
                                    x.prev = p.prev.prev;
                                    p.prev.prev.next = x;
                                    p.prev.prev = null;
                                    p = x.next;
                                }
                                else
                                {
                                    r = double.Parse(p.prev.data) + double.Parse(p.next.data);
                                    x.data = r.ToString();
                                    x.next = p.next.next;
                                    x.prev = p.prev.prev;
                                    p.prev.prev.next = x;
                                    p.prev.prev = null;
                                    p.next.next.prev = x;
                                    p.next.next = null;
                                    p = x.next;

                                }
                            }
                            continue;
                        }
                        if (p.data == "-")
                        {
                            if (head.next == p)
                            {
                                r = double.Parse(p.prev.data) - double.Parse(p.next.data);
                                x.data = r.ToString();
                                x.next = p.next.next;
                                x.prev = null;
                                if (x.next != null)
                                {
                                    p.next.next.prev = x;
                                    p.next.next = null;
                                }
                                p = x.next; 
                                head = x;
                            }
                            else
                            {
                                if (p.next.next == null)
                                {
                                    r = double.Parse(p.prev.data) - double.Parse(p.next.data);
                                    x.data = r.ToString();
                                    x.next = null;
                                    x.prev = p.prev.prev;
                                    p.prev.prev.next = x;
                                    p.prev.prev = null;
                                    p = x.next;
                                }
                                else
                                {
                                    r = double.Parse(p.prev.data) - double.Parse(p.next.data);
                                    x.data = r.ToString();
                                    x.next = p.next.next;
                                    x.prev = p.prev.prev;
                                    p.prev.prev.next = x;
                                    p.prev.prev = null;
                                    p.next.next.prev = x;
                                    p.next.next = null;
                                    p = x.next;

                                }
                            }
                            continue;
                        }
                    }
                    if (p.next != null)
                    {
                        p = p.next;
                    }
                    else
                    {
                        p = p.next.next;
                    }
                    
                }
        
                string str = head.data;
                clearNodes();
                foreach (char n in str)
                {
                    insertatend(n.ToString());
                }
                return str;
            }
        }

    }
}