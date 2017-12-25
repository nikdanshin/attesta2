using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace _8._8
{
    //Условие.
    //(*) У вас есть несколько гирь (<= 10) разного веса (по одной каждого веса). 
    //Вам необходимо найти все возможные способы, которым можно составить вес sumWeight. Решение задачи необходимо реализовать в виде функции: 
    //public List<List<int» SelectionCount( 
    //IList<int> weights, int sumWeight) , 
    //где 
    //‒ weights – веса гирь; 
    //‒ sumWeight – вес, который необходимо набрать.
    //Функция возвращает все подходящие варианты в виде списка вариантов, где подходящий вариант, в свою очередь, представлен списком чисел – весов гирь из которых составлен необходимый общий вес.
    //Подсказка: надо перебрать все возможные числа от 0 до 2n – 1, где n – кол-во весов различных гирь. В этом случае младшие биты соответствующих чисел будут образовывать все возможные комбинации гирь (1 – соответствующая гиря включается в набор, 0 – нет). 
    //Остается проверить вес каждой комбинации и, если он равен нужному, включить соответствующую комбинацию в итоговый набор(список вариантов).

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> weights = ListConvert.GetList(ListInput.Text);
                if (weights.Count > 10)
                {
                    throw new Exception();
                }
                int sumWeight = int.Parse(IntInput.Text);
                ToolsList toolsList = new ToolsList();
                List<List<int>> result = toolsList.SelectionCount(weights, sumWeight);
                if(result.Count > 0)
                {
                    Output.Text = ListConvert.GetString(result);
                }
                else
                {
                    Output.Text = "комбинаций не найдено";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка ввода", "ошибка");
            }
        }
    }
}
