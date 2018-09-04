#pragma once
#include <locale.h>
#include <random>
#include <time.h>

namespace MSAccess {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::Data::OleDb;
	using namespace Microsoft::VisualBasic;

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
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Button^  button2;

	private: System::Windows::Forms::Button^  button4;
	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::DataGridView^  dataGridView1;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^  Mas;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^  Rezmas;
	protected:

	private:
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->Mas = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Rezmas = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(24, 65);
			this->button1->Margin = System::Windows::Forms::Padding(6);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(324, 44);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Cоздание БД";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(24, 121);
			this->button2->Margin = System::Windows::Forms::Padding(6);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(324, 70);
			this->button2->TabIndex = 1;
			this->button2->Text = L"Создание таблицы и строчек\r\n";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(24, 203);
			this->button4->Margin = System::Windows::Forms::Padding(6);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(324, 96);
			this->button4->TabIndex = 3;
			this->button4->Text = L"Генерация массива и резмассива, их вывод и запись в БД\r\n\r\n";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &MyForm::button4_Click);
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(317, 9);
			this->textBox1->Margin = System::Windows::Forms::Padding(6);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(66, 31);
			this->textBox1->TabIndex = 4;
			this->textBox1->Text = L"10";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(19, 9);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(289, 50);
			this->label1->TabIndex = 5;
			this->label1->Text = L"Кол-во элементов массива:\r\n\r\n";
			// 
			// dataGridView1
			// 
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(2) { this->Mas, this->Rezmas });
			this->dataGridView1->Location = System::Drawing::Point(422, 12);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->RowTemplate->Height = 33;
			this->dataGridView1->ScrollBars = System::Windows::Forms::ScrollBars::Vertical;
			this->dataGridView1->Size = System::Drawing::Size(526, 420);
			this->dataGridView1->TabIndex = 6;
			// 
			// Mas
			// 
			this->Mas->HeaderText = L"Mas";
			this->Mas->Name = L"Mas";
			// 
			// Rezmas
			// 
			this->Rezmas->HeaderText = L"Rezmas";
			this->Rezmas->Name = L"Rezmas";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(12, 25);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(960, 570);
			this->Controls->Add(this->dataGridView1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Margin = System::Windows::Forms::Padding(6);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
				 ADOX::Catalog ^ Catalog = gcnew ADOX::CatalogClass();   
				 try   
				 { 
					 Catalog->Create("Provider=Microsoft.Jet." + "OLEDB.4.0;Data Source=new_BD.mdb");
					 MessageBox::Show("База данных new_BD.mdb успешно создана"); 
				 }
				 catch (System::Runtime::InteropServices::COMException ^ Ситуация)   
				 { 
					 MessageBox::Show(Ситуация->Message); 
				 }
				 finally   
				 { 
					 Catalog = nullptr;
				 }
	}
	private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) {
				 // ЗАПИСЬ СТРУКТУРЫ ТАБЛИЦЫ В ПУСТУЮ БД:  
				 // Создание экземпляра объекта Connection с указанием строки  
				 // подключения:  
				 auto Connection = gcnew OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=new_BD.mdb");  
				 // Открытие подключения:  
				 Connection->Open();
				 // Создание экземпляра объекта класса Command  
				 // с заданием SQL-запроса:  
				 auto Command = gcnew OleDbCommand("CREATE TABLE [Massives] ([Mas] string, [Rezmas] string)", Connection);
				 try  // Выполнение команды SQL:  
				 {   
					 Command->ExecuteNonQuery();
					 MessageBox::Show("Структура таблиц записана в пустую БД");
				 }  
				 catch (Exception ^ Situation)  
				 {   
					 MessageBox::Show(Situation->Message);
				 }  
				 Connection->Close();
				 delete Command;
				 delete Connection;
	}

	private: System::Void button4_Click(System::Object^  sender, System::EventArgs^  e) {
				 int len = Convert::ToInt32(textBox1->Text);
				 int* mas = new int[len];
				 int* rezmas = new int[len];
				 ClassLibrary1::ClassLib::genmas(mas, len);
				 int lenrez = ClassLibrary1::ClassLib::setrezmas(mas, rezmas, len);
				 int j = 0;
				 for (int i = 0; i < len; i++) {
					 if (j >= lenrez)
						 rezmas[j] = 0;
					 dataGridView1->Rows->Add();
					 dataGridView1->Rows[i]->Cells[0]->Value = mas[i].ToString();
					 dataGridView1->Rows[i]->Cells[1]->Value = rezmas[i].ToString();
					 auto Connection = gcnew OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=new_BD.mdb");
					 auto Command = gcnew OleDbCommand("INSERT INTO Massives (Mas, Rezmas) VALUES (" + mas[i] +  "," + rezmas[j] +")");
					 Connection->Open();
					 Command->Connection = Connection;
					 Command->ExecuteNonQuery();
					 Connection->Close();
					 delete Connection, Command;
					 j++;
				 }
				 MessageBox::Show("В таблицы добавлены записи");		 
	}	 
};
}
