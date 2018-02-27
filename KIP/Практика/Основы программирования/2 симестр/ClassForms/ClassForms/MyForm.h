#pragma once

namespace ClassForms {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для MyForm
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
		/// Освободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^  textBox1;
	protected:
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::TextBox^  textBox2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::TextBox^  textBox3;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::TextBox^  textBox4;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::TextBox^  textBox5;
	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::TextBox^  textBox6;
	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::TextBox^  textBox7;
	private: System::Windows::Forms::Label^  label8;
	private: System::Windows::Forms::TextBox^  textBox8;
	private: System::Windows::Forms::Button^  button1;

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->textBox4 = (gcnew System::Windows::Forms::TextBox());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->textBox5 = (gcnew System::Windows::Forms::TextBox());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->textBox6 = (gcnew System::Windows::Forms::TextBox());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->textBox7 = (gcnew System::Windows::Forms::TextBox());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->textBox8 = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(12, 40);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(100, 31);
			this->textBox1->TabIndex = 0;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(12, 9);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(36, 25);
			this->label1->TabIndex = 1;
			this->label1->Text = L"a1";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(12, 84);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(36, 25);
			this->label2->TabIndex = 3;
			this->label2->Text = L"a2";
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(12, 115);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(100, 31);
			this->textBox2->TabIndex = 2;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(12, 162);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(36, 25);
			this->label3->TabIndex = 5;
			this->label3->Text = L"a3";
			// 
			// textBox3
			// 
			this->textBox3->Location = System::Drawing::Point(12, 193);
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(100, 31);
			this->textBox3->TabIndex = 4;
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(12, 238);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(36, 25);
			this->label4->TabIndex = 7;
			this->label4->Text = L"b1";
			// 
			// textBox4
			// 
			this->textBox4->Location = System::Drawing::Point(12, 269);
			this->textBox4->Name = L"textBox4";
			this->textBox4->Size = System::Drawing::Size(100, 31);
			this->textBox4->TabIndex = 6;
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(12, 314);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(36, 25);
			this->label5->TabIndex = 9;
			this->label5->Text = L"b2";
			// 
			// textBox5
			// 
			this->textBox5->Location = System::Drawing::Point(12, 345);
			this->textBox5->Name = L"textBox5";
			this->textBox5->Size = System::Drawing::Size(100, 31);
			this->textBox5->TabIndex = 8;
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(129, 9);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(35, 25);
			this->label6->TabIndex = 11;
			this->label6->Text = L"c1";
			// 
			// textBox6
			// 
			this->textBox6->Location = System::Drawing::Point(129, 40);
			this->textBox6->Name = L"textBox6";
			this->textBox6->Size = System::Drawing::Size(100, 31);
			this->textBox6->TabIndex = 10;
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(129, 84);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(35, 25);
			this->label7->TabIndex = 13;
			this->label7->Text = L"c2";
			// 
			// textBox7
			// 
			this->textBox7->Location = System::Drawing::Point(129, 115);
			this->textBox7->Name = L"textBox7";
			this->textBox7->Size = System::Drawing::Size(100, 31);
			this->textBox7->TabIndex = 12;
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(129, 162);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(23, 25);
			this->label8->TabIndex = 15;
			this->label8->Text = L"x";
			// 
			// textBox8
			// 
			this->textBox8->Location = System::Drawing::Point(129, 193);
			this->textBox8->Name = L"textBox8";
			this->textBox8->Size = System::Drawing::Size(100, 31);
			this->textBox8->TabIndex = 14;
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(449, 397);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(133, 54);
			this->button1->TabIndex = 16;
			this->button1->Text = L"Расчет";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(12, 25);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(594, 463);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->label8);
			this->Controls->Add(this->textBox8);
			this->Controls->Add(this->label7);
			this->Controls->Add(this->textBox7);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->textBox6);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->textBox5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->textBox4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->textBox3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->textBox1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
		Double a1, a2, a3, b1, b2, c1, c2, x, min, max, y1, y2, y3;
		a1 = Convert::ToDouble(textBox1->Text);
		a2 = Convert::ToDouble(textBox2->Text);
		a3 = Convert::ToDouble(textBox3->Text);
		b1 = Convert::ToDouble(textBox4->Text);
		b2 = Convert::ToDouble(textBox5->Text);
		c1 = Convert::ToDouble(textBox6->Text);
		c2 = Convert::ToDouble(textBox7->Text);
		x = Convert::ToDouble(textBox8->Text);
		if (x > 1) 
		{
			min = c1;
			if (c2 < min)
				min = c2;
			max = b1;
			if (b2 > max)
				max = b2;
			if (min > max)
				max = min;
			y1 = max;
			MessageBox::Show(Convert::ToString(y1));
		}
		else
		{
			if ((-1 < x) && (x < 1)) {
				min = a1;
				if (a2 < min)
					min = a2;
				if (a3 < min)
					min = a3;
				y2 = min;
				MessageBox::Show(Convert::ToString(y2));
			}
			else
			{
				y3 = 1;
				MessageBox::Show(Convert::ToString(y3));
			}

		}
	}
};
}
