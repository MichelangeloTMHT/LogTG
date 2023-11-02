using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginTG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Создаём экземпляр класса телега.
        Telega Telega = new Telega();

//И создаём экземпляр результата входа
        ClientResult Result = new ClientResult();
        
        async private  void btnSendPhone_Click(object sender, EventArgs e)
        {
            try
            {
                //Вытягиваем номер телефона из окошка
                Telega.ClientNumber = textBoxPhone.Text;

                //Пробуем авторизироватсья
                Result = await Telega.Auth();
                if (!Result.IsDone)
                {
                    //labelCode.Visible = true;
                    textBoxCode.Visible = true;
                   // buttonSendCode.Visible = true;
                }
                //Показываем результат авторизации 
                if (Result.Message!=null)
                    lbStatus.Text = Result.Message;

            }
            catch (Exception ex)
            {
                lbStatus.Text = ex.Message ;
            }
            
        }
      
       
      
        async  void btnSendCode_Click(object sender, EventArgs e)
        {

            try
            {
                Telega.Hash = textBoxCode.Text;
                Result = await Telega.Verify();

                if(Result.Message != null)
                    lbStatus.Text = Result.Message ;
            }
            catch (Exception ex)
            {
                lbStatus.Text = ex.Message;
            }

        }
    }
}