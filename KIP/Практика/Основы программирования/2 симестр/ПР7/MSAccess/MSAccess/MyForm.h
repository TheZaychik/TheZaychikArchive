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
	private: System::Windows::Forms::Button^  button3;
	private: System::Windows::Forms::Button^  button4;
	private: System::Windows::Forms::TextBox^  textBox1;
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
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(24, 23);
			this->button1->Margin = System::Windows::Forms::Padding(6);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(176, 44);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Cоздание БД";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(24, 79);
			this->button2->Margin = System::Windows::Forms::Padding(6);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(244, 44);
			this->button2->TabIndex = 1;
			this->button2->Text = L"Добавление записи";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(24, 135);
			this->button3->Margin = System::Windows::Forms::Padding(6);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(324, 44);
			this->button3->TabIndex = 2;
			this->button3->Text = L"Запись структуры таблицы";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &MyForm::button3_Click);
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(24, 190);
			this->button4->Margin = System::Windows::Forms::Padding(6);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(324, 68);
			this->button4->TabIndex = 3;
			this->button4->Text = L"Запись результирующего массива";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &MyForm::button4_Click);
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(360, 142);
			this->textBox1->Margin = System::Windows::Forms::Padding(6);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(66, 31);
			this->textBox1->TabIndex = 4;
			this->textBox1->Text = L"1";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(12, 25);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1100, 570);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Margin = System::Windows::Forms::Padding(6);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
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
				 auto Command = gcnew OleDbCommand("CREATE TABLE [" + "БД телефонов] ([Номер п/п] counter, [ФИО] char(20), [Номер телефона] string)", Connection);
				 try  // Выполнение команды SQL:  
				 {   
					 Command->ExecuteNonQuery();
					 MessageBox::Show("Структура таблицы 'БД телефонов' записана в пустую БД");
				 }  
				 catch (Exception ^ Situation)  
				 {   
					 MessageBox::Show(Situation->Message);
				 }  
				 Connection->Close();
	}
	private: System::Void button3_Click(System::Object^  sender, System::EventArgs^  e) {
				 // Создание экземпляра объекта Connection  
				 // с указанием строки подключения:  
				 auto Connection = gcnew OleDbConnection(   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=new_BD.mdb");  
				 // Открытие подключения:  
				 Connection->Open();
				 // Создание экземпляра объекта Command с заданием SQL-запроса:  
				 auto Command = gcnew OleDbCommand(   "INSERT INTO [бд телефонов] (" +   "Фио, [номер телефона]) VALUES ('Света', '521-61-41')");
				 // Для добавления записи в таблицу БД эта команда обязательна:  
				 Command->Connection = Connection;
				 // Выполнение команды SQL:  
				 Command->ExecuteNonQuery();
				 MessageBox::Show("В таблицу 'БД телефонов' добавлена запись");  
				 Connection->Close();
	}
	private: System::Void button4_Click(System::Object^  sender, System::EventArgs^  e) {
				 int len = Convert::ToInt32(textBox1->Text);
				 int* mas = new int[len];
				 int* rezmas = new int[len];
				 genmas(mas, len);
				 auto Connection = gcnew OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=new_BD.mdb");
				 Connection->Open();
				 auto Command = gcnew OleDbCommand("INSERT INTO [бд телефонов] (Фио, [номер телефона]) VALUES ('ЧислПосл', '" + setrezmas(mas, rezmas, len) +"')");
				 Command->Connection = Connection;
				 Command->ExecuteNonQuery();
				 MessageBox::Show("В таблицу 'БД телефонов' добавлена запись");
				 Connection->Close();
	}
			 void genmas(int* mas, int len) {
				 srand(time(NULL));
				 for (int i = 0; i < len; i++)
					 mas[i] = -20 + rand() % 45;
	}
			 String^ setrezmas(int* mas, int* rezmas, int len) {
				 String^ ans = "";
				 int j = 0;
				 for (int i = 0; i < len; i++) {
					 if ((mas[i] % 2 == 0) && (mas[i] % 3 != 0)) {
						 rezmas[j] = mas[i];
						 ans += Convert::ToString(rezmas[i]);
						 j++;
					 }
				 }
				 return ans;
			 }
};
}
