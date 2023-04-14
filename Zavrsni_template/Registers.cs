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
    public partial class Registers : Form
    {
        public Registers()
        {
            InitializeComponent();
        }

        private void Registers_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = @"Registers are small, fast storage locations within a computer's processor. They are used to hold data, such as operands and results of operations, as well as intermediate values and addresses during the execution of instructions. Registers are essential components of a computer's central processing unit (CPU).

Some common types of registers include:

1. General-purpose registers: These registers store data and intermediate values during the execution of instructions. They can be used for various purposes, such as holding operands, addresses, or results.

2. Accumulator: The accumulator is a special register used to store the results of arithmetic and logic operations. It is often part of the ALU (Arithmetic Logic Unit) within the CPU.

3. Program counter (PC): The program counter holds the memory address of the next instruction to be executed. The CPU fetches the instruction from this address, increments the PC to point to the next instruction, and then executes the fetched instruction.

4. Instruction register (IR): The instruction register holds the current instruction being executed by the CPU. It is used to store the fetched instruction from memory before it is decoded and executed.

5. Stack pointer (SP): The stack pointer is a register that points to the top of the stack in memory. It is used to keep track of the stack's location, which is essential for function calls, parameter passing, and local variable storage.

6. Base pointer (BP) or Frame pointer (FP): These registers are used to establish a reference point for accessing local variables and function parameters within the current stack frame.";

        }
    }
}
