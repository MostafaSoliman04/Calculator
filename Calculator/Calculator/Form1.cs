using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
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
            n.clearNodes();
            if (x == "error")
            {
                output.Text = x;
            }
            else
            {
                output.Text = x;
                for (int i = 0; i < x.Length; i++)
                {
                    
                    n.insertatend(x[i].ToString());
                }
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
            output.Text = output.Text+ "/";
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
            output.Text = string.Empty;

        }



        class Node
        {
            public string data;
            public Node next;
        }
        class linkedlist
        {
            Node head;
            public void insertatend(string data)
            {
                Node temp = new Node();
                temp.data = data;
                if (head == null)
                {
                    head = temp;
                    return;
                }
                Node p = head;
                while (p.next != null)
                {
                    p = p.next;
                }
                temp.next = p.next;
                p.next = temp;
            }
            public void deletNode()
            {
                Node p = head;
                if (p.next == null)
                {
                    p = null;
                    return;
                }
                while (p.next.next != null)
                    p = p.next;
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
                //if (head.data == "-")
                //    p = p.next;
                while (p != null)
                {
                    
                    if (p.data == "+" || p.data == "-" || p.data == "*" || p.data == "/" || p.data == "%")
                    {
                        
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
                //if (head.data == "-")
                //{
                //    str = str + p.data;
                //    p = p.next;
                //}
                while(p != null)
                {    
                    if (p.data == "+" || p.data == "*" || p.data == "-" || p.data == "/" || p.data == "%")
                    {
                        arr[x] = str;
                        x++;
                        str = "";
                        arr[x] = p.data;
                        x++;
                        //if (p.next.data == "-")
                        //{
                        //    p = p.next;
                        //    str = str + "-";
                        //}
                    }
                    else
                    {
                        str = str + p.data;
                    }
                    p = p.next;
                }
                arr[x] = str;
            }
            
            public string result()
            {
                creatarray();
                int x = 0;
                float num1 = 0, num2 = 0;
                while (x < arr.Length)
                {
                    
                    if (arr[x] == "+")
                    {
                        num1 = float.Parse(arr[x-1]);
                        num2 = float.Parse(arr[x+1]);
                        float sum = num1 + num2;
                        arr[x + 1] = sum.ToString();
                    }
                    if (arr[x] == "-")
                    {
                        num1 = float.Parse(arr[x - 1]);
                        num2 = float.Parse(arr[x + 1]);
                        float sub = num1 - num2;
                        arr[x + 1] = sub.ToString();

                    }
                    if (arr[x] == "*")
                    {
                        num1 = float.Parse(arr[x - 1]);
                        num2 = float.Parse(arr[x + 1]);
                        float mult = num1 * num2;
                        arr[x + 1] = mult.ToString();
                    }
                    if (arr[x] == "/")
                    {
                        num1 = float.Parse(arr[x - 1]);
                        num2 = float.Parse(arr[x + 1]);
                        if(num2 == 0)
                        {
                            return "error";
                        }
                        float divide = num1 / num2;
                        arr[x + 1] = divide.ToString();
                    }
                    if (arr[x] == "%")
                    {
                        num1 = float.Parse(arr[x - 1]);
                        num2 = float.Parse(arr[x + 1]);
                        if (num2 > num1)
                        {
                            return "error";
                        }
                        float model = num1 % num2;
                        arr[x+1] = model.ToString();
                    }
                    x++;
                }
                return  arr[x-1];

            }

        }
    }
}