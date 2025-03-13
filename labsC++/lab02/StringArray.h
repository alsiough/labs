#ifndef STRINGARRAY_H
#define STRINGARRAY_H

#include <string>

class StringArray {
private:
    std::string data;  
public:
    
    StringArray();

    
    StringArray(const std::string& str);

    
    ~StringArray();

    
    size_t length() const;

    
    void removeChar(char c);

    
    std::string getData() const;
};

#endif 
