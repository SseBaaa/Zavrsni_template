using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavrsni_template
{
    public partial class Heap : Form
    {
        public Heap()
        {
            InitializeComponent();
        }

        private void Heap_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = @"Heap and stack are two memory regions used to manage memory in computer programs. Each has distinct characteristics and use cases.

Heap memory management:
- Heap is a region of memory used for dynamic memory allocation.
- Memory is allocated and deallocated on-demand during the program execution.
- The programmer has direct control over heap memory allocation and deallocation.
- Heap memory allocation can be slower than stack allocation due to the bookkeeping overhead involved.
- Fragmentation can occur, leading to inefficient memory usage.

Stack memory management:
- Stack is a region of memory used for automatic memory allocation.
- Memory is allocated and deallocated automatically when functions are called and return.
- The programmer doesn't have direct control over stack memory allocation and deallocation.
- Stack memory allocation is generally faster than heap allocation, as it involves only incrementing or decrementing the stack pointer.
- Memory usage is more efficient due to the LIFO (Last In, First Out) nature of stack allocation.

In summary, heap memory is used for dynamic memory allocation, which provides more flexibility and control but can introduce inefficiencies and complexities. Stack memory is used for automatic memory allocation and is generally more efficient, but its size and usage are determined at compile-time.";
        }
    }
}
