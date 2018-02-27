#include "MyForm1.h" // менять инклюд формы в соответсвии с практической 
#include <Windows.h>
using namespace Project1;

int WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Application::Run(gcnew MyForm1); // тут тоже
	return 0;
}