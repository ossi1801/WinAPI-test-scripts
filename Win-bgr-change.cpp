#include <iostream>
#include <windows.h>
#include <stdlib.h>    
#include <string> 
using namespace std;    

//3 frame .png anim
int main() {
	const char* file = "C:\\Users\\User1\\Pictures\\Backgrounds\\Anim\\";
	while(true)
	{
		
		for (int i = 1; i < 3; i++) { 
			std::string f = file;		
			std::string str = std::to_string(i);
			SystemParametersInfoA(SPI_SETDESKWALLPAPER, 0, (void*)((f + str + ".png").c_str()), SPIF_UPDATEINIFILE); //Sets as win bgr 
			Sleep(100);
			//cout << (f + str[i] + ".png").c_str() << endl;
		}	
		for (int i = 3; i-- > 1; ) //Reverse animation
		{
			
			std::string f = file;
			std::string str = std::to_string(i);
			SystemParametersInfoA(SPI_SETDESKWALLPAPER, 0, (void*)((f + str + ".png").c_str()), SPIF_UPDATEINIFILE);
			Sleep(100);
		
		}
		Sleep(1500);

	}

 

    return 0;
}
