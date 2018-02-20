#pragma once
#include <Math.h>;


namespace Project1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// —водка дл€ MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// ќсвободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::Windows::Forms::TextBox^  textBox2;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::TextBox^  textBox3;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::TextBox^  textBox4;
	private: System::Windows::Forms::Label^  label4;
	protected:

	private:
		/// <summary>
		/// ќб€зательна€ переменна€ конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// “ребуемый метод дл€ поддержки конструктора Ч не измен€йте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->textBox4 = (gcnew System::Windows::Forms::TextBox());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(447, 416);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(137, 43);
			this->button1->TabIndex = 0;
			this->button1->Text = L"–асчет";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(23, 46);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(113, 25);
			this->label1->TabIndex = 1;
			this->label1->Text = L"¬ведите а";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(28, 74);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(108, 31);
			this->textBox1->TabIndex = 2;
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(28, 152);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(108, 31);
			this->textBox2->TabIndex = 4;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(23, 124);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(113, 25);
			this->label2->TabIndex = 3;
			this->label2->Text = L"¬ведите b";
			// 
			// textBox3
			// 
			this->textBox3->Location = System::Drawing::Point(28, 230);
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(108, 31);
			this->textBox3->TabIndex = 6;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(23, 202);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(112, 25);
			this->label3->TabIndex = 5;
			this->label3->Text = L"¬ведите х";
			// 
			// textBox4
			// 
			this->textBox4->Location = System::Drawing::Point(28, 308);
			this->textBox4->Name = L"textBox4";
			this->textBox4->Size = System::Drawing::Size(108, 31);
			this->textBox4->TabIndex = 8;
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(23, 280);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(112, 25);
			this->label4->TabIndex = 7;
			this->label4->Text = L"¬ведите с";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(12, 25);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(596, 471);
			this->Controls->Add(this->textBox4);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->textBox3);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm";
			this->Text = L"PR-1";
			this->ResumeLayout(false);
			this->PerformLayout();
1
; }
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
		Int32 a, b, x, c;
		a = Convert::ToInt32(textBox1->Text);
		b = Convert::ToInt32(textBox2->Text);
		x = Convert::ToInt32(textBox3->Text);
		c = Convert::ToInt32(textBox4->Text);
		MessageBox::Show("z = " + Convert::ToString(exp(-c * x)*(x + sqrt(x + a)) / (x - sqrt(abs(x - b)))) + " f = " + Convert::ToString(log10(a + pow(x, 2)) + pow(sin(x / b), 2)));
	}
};
}
