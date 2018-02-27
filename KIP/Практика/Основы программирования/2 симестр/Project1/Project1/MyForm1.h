#pragma once
#include <math.h>;
namespace Project1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// —водка дл€ MyForm1
	/// </summary>
	public ref class MyForm1 : public System::Windows::Forms::Form
	{
	public:
		MyForm1(void)
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
		~MyForm1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^  textBox4;
	protected:
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::TextBox^  textBox3;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::TextBox^  textBox2;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Button^  button1;

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
			this->textBox4 = (gcnew System::Windows::Forms::TextBox());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// textBox4
			// 
			this->textBox4->Location = System::Drawing::Point(28, 206);
			this->textBox4->Name = L"textBox4";
			this->textBox4->Size = System::Drawing::Size(108, 31);
			this->textBox4->TabIndex = 17;
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(23, 178);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(112, 25);
			this->label4->TabIndex = 16;
			this->label4->Text = L"¬ведите с";
			// 
			// textBox3
			// 
			this->textBox3->Location = System::Drawing::Point(28, 128);
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(108, 31);
			this->textBox3->TabIndex = 15;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(23, 100);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(112, 25);
			this->label3->TabIndex = 14;
			this->label3->Text = L"¬ведите х";
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(28, 50);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(108, 31);
			this->textBox2->TabIndex = 13;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(23, 22);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(113, 25);
			this->label2->TabIndex = 12;
			this->label2->Text = L"¬ведите b";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(325, 324);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(137, 43);
			this->button1->TabIndex = 9;
			this->button1->Text = L"–асчет";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm1::button1_Click);
			// 
			// MyForm1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(12, 25);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(474, 379);
			this->Controls->Add(this->textBox4);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->textBox3);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm1";
			this->Text = L"PR-2";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
		Double b, x, c, min, max;
		b = Convert::ToDouble(textBox2->Text);
		x = Convert::ToDouble(textBox3->Text);
		c = Convert::ToDouble(textBox4->Text);
		if (x > 1) {
			MessageBox::Show("(1) z = " + Convert::ToString(x*sqrt(b*b + c * c)));
		}
		else if (x <= 0) {
			min = sqrt(b);
			if (x*x < min)
				min = x * x;
			if (x + c < min)
				min = x + c;
			MessageBox::Show("(2) z = " + Convert::ToString(min));
		}
		else {
			max = log10(b);
			if (x + c > max)
				max = x + c;
			MessageBox::Show("(3) z = " + Convert::ToString(max));
		}
	}
};
}
