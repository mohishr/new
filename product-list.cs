using System;

namespace product_list_namespace
{
    public class product_list
    {
        public int top { set; get; }
        public product[] list;
        
        public product_list(){
            
        }
        public class product
        {
            public string product_name { set; get; }
            public int product_id { set; get; }

            public product(string product_name, int product_id)
            {
                this.product_name = product_name;
                this.product_id = product_id;
            }
            public product(){
                this.product_name = string.Empty;
                this.product_id=-1;
            }
        }
    }
}
