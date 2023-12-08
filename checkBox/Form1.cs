using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkBox
{
    public partial class Form1 : Form
    {
        public CheckBox[] bitCheckBoxes;

        public Form1()
        {
            InitializeComponent();
            InitializeBitCheckBoxes();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flowLayoutPanelBits.Dock = DockStyle.Bottom;
            this.MinimumSize = new System.Drawing.Size(490, 600);
            timer1.Start();
        }

        private void InitializeBitCheckBoxes()
        {
            // 비트 수 설정
            int bitCount = 64;

            bitCheckBoxes = new CheckBox[bitCount];


            for (int i = bitCount - 1; i >= 48; i--)
            {
                // CheckBox 생성
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "0";
                checkBox.CheckedChanged += BitCheckBox_CheckedChanged;

                // 폼에 추가
                tableLayoutPanel7.Controls.Add(checkBox);

                // 배열에 저장
                bitCheckBoxes[i] = checkBox;

                // 체크박스 디자인
                checkBox.Appearance = Appearance.Button;
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.FlatAppearance.BorderSize = 0;
                checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom ;
                checkBox.Font = new Font("맑은 고딕", 12, FontStyle.Bold);

                // FlatAppearance 설정
                checkBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(173, 216, 230); // 클릭 시 배경색
                checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(243, 243, 243); // 체크 시 배경색

            }

            for (int i = 47; i >= 32; i--)
            {
                // CheckBox 생성
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "0";
                checkBox.CheckedChanged += BitCheckBox_CheckedChanged;

                // 폼에 추가
                tableLayoutPanel5.Controls.Add(checkBox);

                // 배열에 저장
                bitCheckBoxes[i] = checkBox;

                // 체크박스 디자인
                checkBox.Appearance = Appearance.Button;
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.FlatAppearance.BorderSize = 0;
                checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                checkBox.Font = new Font("맑은 고딕", 12, FontStyle.Bold);

                // FlatAppearance 설정
                checkBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(173, 216, 230); // 클릭 시 배경색
                checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(243, 243, 243); // 체크 시 배경색

            }

            for (int i = 31; i >= 16; i--)
            {
                // CheckBox 생성
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "0";
                checkBox.CheckedChanged += BitCheckBox_CheckedChanged;

                // 폼에 추가
                tableLayoutPanel3.Controls.Add(checkBox);

                // 배열에 저장
                bitCheckBoxes[i] = checkBox;

                // 체크박스 디자인
                checkBox.Appearance = Appearance.Button;
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.FlatAppearance.BorderSize = 0;
                checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                checkBox.Font = new Font("맑은 고딕", 12, FontStyle.Bold);

                // FlatAppearance 설정
                checkBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(173, 216, 230); // 클릭 시 배경색
                checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(243, 243, 243); // 체크 시 배경색

            }

            for (int i = 15; i >= 0; i--)
            {
                // CheckBox 생성
                CheckBox checkBox = new CheckBox();
                checkBox.Text = "0";
                checkBox.CheckedChanged += BitCheckBox_CheckedChanged;

                // 폼에 추가
                tableLayoutPanel1.Controls.Add(checkBox);

                // 배열에 저장
                bitCheckBoxes[i] = checkBox;

                // 체크박스 디자인
                checkBox.Appearance = Appearance.Button;
                checkBox.FlatStyle = FlatStyle.Flat;
                checkBox.FlatAppearance.BorderSize = 0;
                checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                checkBox.Font = new Font("맑은 고딕", 12, FontStyle.Bold);

                // FlatAppearance 설정
                checkBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(173, 216, 230); // 클릭 시 배경색
                checkBox.FlatAppearance.CheckedBackColor = Color.FromArgb(243, 243, 243); // 체크 시 배경색

            }
        }

    private void BitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox가 변경되었을 때 처리할 로직 추가
            UpdateResult();
        }

        private void UpdateResult()
        {
            // 선택된 비트를 이용한 계산 로직 추가
            long result = 0;
            for (int i = 0; i < bitCheckBoxes.Length; i++)
            {
                if (bitCheckBoxes[i].Checked)
                {
                    result |= (1L << i);
                    bitCheckBoxes[i].Text = "1";
                    //long temp = 1;
                    //for (int j = 0; j < i; j++)
                    //{
                    //    temp *= 2;
                    //}
                    //result |= temp;
                }
                else
                {
                    bitCheckBoxes[i].Text = "0";
                }
            }

            // 계산 결과를 텍스트 상자에 표시
            textBoxResult.Text = result.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(this.Height * 0.05625);
            tableLayoutPanel1.Height = y;
            tableLayoutPanel2.Height = y;
            tableLayoutPanel3.Height = y;
            tableLayoutPanel4.Height = y;
            tableLayoutPanel5.Height = y;
            tableLayoutPanel6.Height = y;
            tableLayoutPanel7.Height = y;
            flowLayoutPanelBits.Height = y;
        }
                
    }
}
