using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP2_Midterms
{
    public partial class Irregular : Form
    {
        DataTable table1 = new DataTable("Table");
        DataTable table2 = new DataTable("Table");
        public Irregular()
        {
            InitializeComponent();
        }

        //year1 - sem1
        String[] subj_no_1_1 = { "CS116L", "CS110", "CS110L", "NSTP1", "PE111", "TH111E", "PH114", "EN110", "MH103", "CS115L", "CS115", "MH110" };
        String[] description_1_1 = { "GRAPHICS DESIGN 1 LAB", "INTRODUCTION TO COMPUTING LEC", "INTRODUCTION TO COMPUTING LAB", "NSTP 1", "PHYSICAL EDUCATION 1	",
                "SEARCHING FOR GOD IN THE WORLD TODAY", "ETHICS", "PURPOSIVE COMMUNICATION", "COMPUTING 1", "COMPUTER PROGRAMMING 1 LAB", "COMPUTER PROGRAMMING 1 LEC", "MATHEMATICS IN THE MODERN WORLD" };
        int[] units_1_1 = { 1, 2, 1, 3, 2, 3, 3, 3, 3, 1, 2, 3 };
        int[] LecLab_1_1 = { 2, 1, 2, 1, 1, 1, 1, 1, 1, 2, 1, 1 };

        //year1 - sem2
        String[] subj_no_1_2 = { "PC217", "PE121", "PY111", "PC110", "TH121E", "MH123A", "CS124L", "CS124", "CS325L", "CS325", "CS121L", "CS121", "PC217L", "NSTP2" };
        String[] description_1_2 = { "APPLIED PHYSICS FOR IT LEC", "PHYSICAL EDUCATION 2", "UNDERSTANDING THE SELF", "SCIENCE, TECHNOLOGY AND SOCIETY", "RESPONDING TO GOD`S CALL BY BECOMING FULLY HUMAN",
                "COMPUTING 2", "COMPUTER PROGRAMMING 2 LAB", "COMPUTER PROGRAMMING 2 LEC", "OBJECT ORIENTED PROG'G. LAB", "OBJECT ORIENTED PROG'G. LEC", "APPLICATIONS DEVT & EMERGING TECHNOLOGIES LAB", "	APPLICATIONS DEVT & EMERGING TECHNOLOGIES LEC",
                    "APPLIED PHYSICS FOR IT LAB", "NSTP 2"};
        int[] units_1_2 = { 2, 2, 3, 3, 3, 3, 1, 2, 1, 2, 1, 2, 1, 3 };
        int[] LecLab_1_2 = { 1, 1, 1, 1, 1, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

        //year2 - sem1
        String[] subj_no_2_1 = { "CS229L", "PE211", "TH211E", "HI112", "HU311", "HI113", "MH219A", "CS216", "CS230", "CS223", "CS230L" };
        String[] description_2_1 = { "COMPUTER ANIMATION LAB", "PHYSICAL EDUCATION 3", "CELEBRATING GOD`S PRESENCE AS A CHRISTIAN COMM", "READINGS IN PHILIPPINE HISTORY", "ART APPRECIATION", "THE CONTEMPORARY WORLD", "COMPUTING 3",
                "DISCRETE STRUCTURES 1", "DIGITAL DESIGN LEC", "DATA STRUCTURE & ALGORITHM", "DIGITAL DESIGN LAB"};
        int[] units_2_1 = { 1, 2, 3, 3, 3, 3, 3, 3, 2, 3, 1 };
        int[] LecLab_2_1 = { 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2 };

        //year2 - sem2
        String[] subj_no_2_2 = { "CS228A", "PE221", "TH221E", "HI311", "MH428", "MH425B", "CS425A", "CS227", "CS220", "CS228AL", "NS211" };
        String[] description_2_2 = { "INFORMATION MANAGEMENT LEC", "PHYSICAL EDUCATION 4", "TRANSFORMING THE WORLD WITH VINCENT DE PAUL", "RIZAL'S LIFE & WORKS", "OPERATIONS RESEARCH", "NUMERICAL ANALYSIS", "ARTIFICIAL INTELLIGENCE",
                "PROGRAMMING LANGUAGES","DISCRETE STRUCTURES 2","INFORMATION MANAGEMENT LAB","ENVIRONMENTAL SCIENCE	" };
        int[] units_2_2 = { 2, 2, 3, 3, 3, 3, 3, 3, 3, 1, 3 };
        int[] LecLab_2_2 = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1 };

        //year3 - sem1
        String[] subj_no_3_1 = { "CS311B", "MH421C", "CSRS2", "CS318", "CSRS1", "CS313B", "CS318L", "CS310A", "CS319A", "PS221B" };
        String[] description_3_1 = { "TECHNOPRENEURSHIP", "ADVANCED STATISTICS", "REQUIRED SPECIALIZATION COURSE 2", "COMP ORG & ASSEMBLY LANG LEC", "REQUIRED SPECIALIZATION COURSE 1", "ALGORITHMS AND COMPLEXITY", "COMP ORG & ASSEMBLY LANG LAB",
            "AUTOMATA THEORY & FORMAL LANGUAGES","SOFTWARE ENGINEERING 1","POLITICS & GOVERNANCE WITH PHILIPPINE CONSTITUTION"};
        int[] units_3_1 = { 3, 3, 3, 2, 3, 3, 1, 3, 3, 3 };
        int[] LecLab_3_1 = { 1, 1, 2, 1, 2, 1, 2, 1, 1, 1 };

        //year3 - sem2
        String[] subj_no_3_2 = { "CS419A", "CSPE1", "CS341", "CSRS3", "CS438A", "CS314L", "CS314", "CS411CL", "CS411C", "AC116" };
        String[] description_3_2 = { "CS RESEARCH PROJECT 1", "PROFESSIONAL ELECTIVE 1", "HUMAN COMPUTER INTERACTION", "REQUIRED SPECIALIZATION COURSE 3", "SOFTWARE ENGINEERING 2", "OPERATING SYSTEMS LAB",
            "OPERATING SYSTEMS LEC","NETWORKS AND COMMUNICATION LAB","NETWORKS AND COMMUNICATION LEC","BASIC ACCOUNTING"};
        int[] units_3_2 = { 3, 3, 3, 3, 3, 1, 2, 1, 2, 3 };
        int[] LecLab_3_2 = { 1, 1, 1, 1, 1, 2, 1, 2, 1, 1 };

        //year4 - sem1
        String[] subj_no_4_1 = { "CS342", "CS420", "CSPE2", "CSPE3" };
        String[] description_4_1 = { "PROFESSIONAL ETHICS", "CS RESEARCH PROJECT 2", "PROFESSIONAL ELECTIVE 2", "PROFESSIONAL ELECTIVE 3" };
        int[] units_4_1 = { 3, 3, 3, 3 };
        int[] LecLab_4_1 = { 1, 1, 2, 2 };

        //year4 - sem2
        String[] subj_no_4_2 = { "CS410", "CS410L", "CSPE4", "CS433B" };
        String[] description_4_2 = { "INFORMATION ASSURANCE & SECURITY LEC", "INFORMATION ASSURANCE AND SECURITY LAB", "PROFESSIONAL ELECTIVE 4", "APPRENTICESHIP" };
        int[] units_4_2 = { 2, 1, 3, 6 };
        int[] LecLab_4_2 = { 1, 2, 1, 2 };

        //ArrayList
        List<String> subj_no = new List<string>();
        List<String> description = new List<string>();
        List<int> units = new List<int>();
        List<int> LecLab = new List<int>();


        //lec & lab
        int lecture = 0;
        int laboratory = 0;

        int lecture_2 = 0;
        int laboratory_2 = 0;

        //container
        List<string> subj_no_list = new List<string>();
        List<string> description_list = new List<string>();
        List<int> units_list = new List<int>();
        List<int> LecLab_list = new List<int>();

        int loop = 0;

        private void Irregular_Load(object sender, EventArgs e)
        {
            String year = registration.year_e;
            String sem = registration.sem_e;

            //table1
            table1.Columns.Add("Subj Code", Type.GetType("System.String"));
            table1.Columns.Add("Description", Type.GetType("System.String"));
            table1.Columns.Add("Units", Type.GetType("System.Int32"));
            dataGridView2.DataSource = table1;

            //table2
            table2.Columns.Add("Subj Code", Type.GetType("System.String"));
            table2.Columns.Add("Description", Type.GetType("System.String"));
            table2.Columns.Add("Units", Type.GetType("System.Int32"));
            dataGridView1.DataSource = table2;

            //year1
            if (year.Equals("1st Year") & sem.Equals("1st Semester"))
            {
                for (int i = 0; i < subj_no_1_1.Length; i++)
                {
                    table1.Rows.Add(subj_no_1_1[i], description_1_1[i], units_1_1[i]);
                    label5.Text = units_1_1.Sum().ToString();
                }
                for (int x = 0; x < LecLab_1_1.Length; x++)
                {
                    if (LecLab_1_1[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_1_1[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            else if (year.Equals("1st Year") & sem.Equals("2nd Semester"))
            {
                for (int i = 0; i < subj_no_1_2.Length; i++)
                {
                    table1.Rows.Add(subj_no_1_2[i], description_1_2[i], units_1_2[i]);
                    label5.Text = units_1_2.Sum().ToString();
                }
                for (int x = 0; x < LecLab_1_2.Length; x++)
                {
                    if (LecLab_1_2[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_1_2[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            //year2
            else if (year.Equals("2nd Year") & sem.Equals("1st Semester"))
            {
                for (int i = 0; i < subj_no_2_1.Length; i++)
                {
                    table1.Rows.Add(subj_no_2_1[i], description_2_1[i], units_2_1[i]);
                    label5.Text = units_2_1.Sum().ToString();
                }
                for (int x = 0; x < LecLab_2_1.Length; x++)
                {
                    if (LecLab_2_1[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_2_1[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            else if (year.Equals("2nd Year") & sem.Equals("2nd Semester"))
            {
                for (int i = 0; i < subj_no_2_2.Length; i++)
                {
                    table1.Rows.Add(subj_no_2_2[i], description_2_2[i], units_2_2[i]);
                    label5.Text = units_2_2.Sum().ToString();
                }
                for (int x = 0; x < LecLab_2_2.Length; x++)
                {
                    if (LecLab_2_2[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_2_2[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            //year3
            else if (year.Equals("3rd Year") & sem.Equals("1st Semester"))
            {
                for (int i = 0; i < subj_no_3_1.Length; i++)
                {
                    table1.Rows.Add(subj_no_3_1[i], description_3_1[i], units_3_1[i]);
                    label5.Text = units_3_1.Sum().ToString();
                }
                for (int x = 0; x < LecLab_3_1.Length; x++)
                {
                    if (LecLab_3_1[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_3_1[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            else if (year.Equals("3rd Year") & sem.Equals("2nd Semester"))
            {
                for (int i = 0; i < subj_no_3_2.Length; i++)
                {
                    table1.Rows.Add(subj_no_3_2[i], description_3_2[i], units_3_2[i]);
                    label5.Text = units_3_2.Sum().ToString();
                }
                for (int x = 0; x < LecLab_3_2.Length; x++)
                {
                    if (LecLab_3_2[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_3_2[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            //year4
            else if (year.Equals("4th Year") & sem.Equals("1st Semester"))
            {
                for (int i = 0; i < subj_no_4_1.Length; i++)
                {
                    table1.Rows.Add(subj_no_4_1[i], description_4_1[i], units_4_1[i]);
                    label5.Text = units_4_1.Sum().ToString();
                }
                for (int x = 0; x < LecLab_4_1.Length; x++)
                {
                    if (LecLab_4_1[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_4_1[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            else if (year.Equals("4th Year") & sem.Equals("2nd Semester"))
            {
                for (int i = 0; i < subj_no_4_2.Length; i++)
                {
                    table1.Rows.Add(subj_no_4_2[i], description_4_2[i], units_4_2[i]);
                    label5.Text = units_4_2.Sum().ToString();
                }
                for (int x = 0; x < LecLab_4_2.Length; x++)
                {
                    if (LecLab_4_2[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_4_2[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String year = registration.year_e;
            String sem = registration.sem_e;

            //read textbox
            string add = textBox2.Text;

            if (year.Equals("1st Year") & sem.Equals("1st Semester"))
            {
                for(int i = 0; i < subj_no_1_1.Length; i++)
                {
                    if (add.Equals(subj_no_1_1[i]))
                    {
                        textBox2.Text = "";
                        table2.Rows.Clear();
                        loop++;
                        subj_no_list.Add(subj_no_1_1[i]);
                        description_list.Add(description_1_1[i]);
                        units_list.Add(units_1_1[i]);
                        for (int j = 0; j < loop; j++)
                        {
                            table2.Rows.Add(subj_no_list[j], description_list[j], units_list[j]);
                        }
                    }
                }
                for (int x = 0; x < subj_no_list.Count; x++)
                {
                    if (LecLab_1_2[x].Equals(1))
                    {
                        lecture_2++;
                    }
                    else if (LecLab_1_2[x].Equals(2))
                    {
                        laboratory_2++;
                    }
                }

            }
            else if (year.Equals("1st Year") & sem.Equals("2nd Semester"))
            {
                for (int i = 0; i < subj_no_1_2.Length; i++)
                {
                    table1.Rows.Add(subj_no_1_2[i], description_1_2[i], units_1_2[i]);
                    label5.Text = units_1_2.Sum().ToString();
                }
                for (int x = 0; x < LecLab_1_2.Length; x++)
                {
                    if (LecLab_1_2[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_1_2[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            //year2
            else if (year.Equals("2nd Year") & sem.Equals("1st Semester"))
            {
                for (int i = 0; i < subj_no_2_1.Length; i++)
                {
                    table1.Rows.Add(subj_no_2_1[i], description_2_1[i], units_2_1[i]);
                    label5.Text = units_2_1.Sum().ToString();
                }
                for (int x = 0; x < LecLab_2_1.Length; x++)
                {
                    if (LecLab_2_1[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_2_1[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            else if (year.Equals("2nd Year") & sem.Equals("2nd Semester"))
            {
                for (int i = 0; i < subj_no_2_2.Length; i++)
                {
                    table1.Rows.Add(subj_no_2_2[i], description_2_2[i], units_2_2[i]);
                    label5.Text = units_2_2.Sum().ToString();
                }
                for (int x = 0; x < LecLab_2_2.Length; x++)
                {
                    if (LecLab_2_2[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_2_2[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            //year3
            else if (year.Equals("3rd Year") & sem.Equals("1st Semester"))
            {
                for (int i = 0; i < subj_no_3_1.Length; i++)
                {
                    table1.Rows.Add(subj_no_3_1[i], description_3_1[i], units_3_1[i]);
                    label5.Text = units_3_1.Sum().ToString();
                }
                for (int x = 0; x < LecLab_3_1.Length; x++)
                {
                    if (LecLab_3_1[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_3_1[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            else if (year.Equals("3rd Year") & sem.Equals("2nd Semester"))
            {
                for (int i = 0; i < subj_no_3_2.Length; i++)
                {
                    table1.Rows.Add(subj_no_3_2[i], description_3_2[i], units_3_2[i]);
                    label5.Text = units_3_2.Sum().ToString();
                }
                for (int x = 0; x < LecLab_3_2.Length; x++)
                {
                    if (LecLab_3_2[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_3_2[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            //year4
            else if (year.Equals("4th Year") & sem.Equals("1st Semester"))
            {
                for (int i = 0; i < subj_no_4_1.Length; i++)
                {
                    table1.Rows.Add(subj_no_4_1[i], description_4_1[i], units_4_1[i]);
                    label5.Text = units_4_1.Sum().ToString();
                }
                for (int x = 0; x < LecLab_4_1.Length; x++)
                {
                    if (LecLab_4_1[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_4_1[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
            else if (year.Equals("4th Year") & sem.Equals("2nd Semester"))
            {
                for (int i = 0; i < subj_no_4_2.Length; i++)
                {
                    table1.Rows.Add(subj_no_4_2[i], description_4_2[i], units_4_2[i]);
                    label5.Text = units_4_2.Sum().ToString();
                }
                for (int x = 0; x < LecLab_4_2.Length; x++)
                {
                    if (LecLab_4_2[x].Equals(1))
                    {
                        lecture++;
                    }
                    else if (LecLab_4_2[x].Equals(2))
                    {
                        laboratory++;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
