#include <iostream>
#include "StringArray.h"

int main() {
    
    StringArray str1;

    
    StringArray str2("123456789");

    std::cout << "length str2: " << str2.length() << std::endl;

    
    str2.removeChar('5');
    std::cout << "line after delete '5': " << str2.getData() << std::endl;

    return 0;
}
