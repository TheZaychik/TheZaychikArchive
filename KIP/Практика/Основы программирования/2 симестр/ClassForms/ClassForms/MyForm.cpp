#include "MyForm.h" // мен€ть инклюд формы в соответсвии с практической 
#include <Windows.h>
using namespace ClassForms;

int WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Application::Run(gcnew MyForm); // тут тоже
	return 0;
}