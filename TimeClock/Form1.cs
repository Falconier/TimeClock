using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeClock
{
				public partial class Form1 : Form
				{

								private DateTime startTime;

								private DateTime endTime;

								private bool onClock;

								public Form1()
								{
												InitializeComponent();
												monthCalendar1.SetDate(DateTime.Now);
												txtCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
								}

								private void btnClockIn_Click(object sender, EventArgs e)
								{
												if (!onClock)
												{
																DialogResult result = MessageBox.Show("Are you sure you want to clock in?", "Clock In", MessageBoxButtons.YesNo);
																if (result == DialogResult.Yes)
																{
																				startTime = DateTime.Now;
																				onClock = true;
																				lblClockIndicator.BackColor = Color.Green;
																}
												}
								}

								private void timer1_Tick(object sender, EventArgs e)
								{
												txtCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
								}

								private void Form1_Load(object sender, EventArgs e)
								{
												timer1.Start();
								}

								private void btnClockOut_Click(object sender, EventArgs e)
								{
												if (onClock)
												{
																DialogResult result = MessageBox.Show("Are you sure you want to clock out?", "Clock Out", MessageBoxButtons.YesNo);
																if (result == DialogResult.Yes)
																{
																				endTime = DateTime.Now;
																				onClock = false;
																				if (!File.Exists("C:\\Users\\jacob\\Desktop\\TimeClock.txt"))
																				{
																								FileStream fs = File.Create("C:\\Users\\jacob\\Desktop\\TimeClock.txt");
																								fs.Close();
																				}
																				int len = (startTime.ToString("dddd, dd MMMM yyyy") + " : " + startTime.ToString("HH:mm tt") + " :: " + endTime.ToString("HH:mm tt") + " ::: " + endTime.Subtract(startTime).Hours + "h-" + endTime.Subtract(startTime).Minutes + "m::: " + endTime.Subtract(startTime).TotalHours).Length;
																				string lineBreak = "";
																				for (int i = 0; i < len + 1; i++)
																				{
																								lineBreak += "=";
																				}
																				StreamWriter sw = File.AppendText("C:\\Users\\jacob\\Desktop\\TimeClock.txt");
																				sw.WriteLine($"{lineBreak}\n{startTime.ToString("dddd, dd MMMM yyyy")} : {startTime.ToString("HH:mm tt")} :: {endTime.ToString("HH:mm tt")} ::: {endTime.Subtract(startTime).Hours}h-{endTime.Subtract(startTime).Minutes}m ::: {endTime.Subtract(startTime).TotalHours}\n{txtDescription.Text.ToString()}\n{lineBreak}\n");
																				sw.Close();
																				lblClockIndicator.BackColor = Color.Red;
																}
												}
								}

								private void Form1_FormClosing(object sender, FormClosingEventArgs e)
								{
												if (onClock)
												{
																DialogResult result = MessageBox.Show("You are on the clock!\nAre you sure you want to clock out?", "Warning - On The Clock", MessageBoxButtons.YesNo);
																if (result == DialogResult.Yes)
																{
																				e.Cancel = false;
																}
																else
																{
																				e.Cancel = true;
																}
												}
								}
				}
}
