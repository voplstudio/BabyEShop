using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    class OrderController
    {
        private Order MyOrder;
        public OrderController (Order a)
        {
            MyOrder = a;
        }
        public void FillForm (OrderForm form)
        {
            form.OrderDateDateTimePicker.Value = MyOrder.OrderDate;
        }
    }
}
