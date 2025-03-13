#include "StringArray.h"


StringArray::StringArray() : data("") {}


StringArray::StringArray(const std::string& str) : data(str) {}


StringArray::~StringArray() {}


size_t StringArray::length() const {
    return data.size();
}


void StringArray::removeChar(char c) {
    data.erase(remove(data.begin(), data.end(), c), data.end());
}


std::string StringArray::getData() const {
    return data;
}
