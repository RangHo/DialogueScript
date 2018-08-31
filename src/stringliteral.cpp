#include "ast/stringliteral.hpp"

namespace dialoguescript::ast
{
    const std::string StringLiteral::NAME = "String Literal";

    StringLiteral::StringLiteral(std::string content)
    {
        this->content = content;
    }

    std::string StringLiteral::get_content() const
    {
        return this->content;
    }

    std::string StringLiteral::ToString() const override
    {
        std::string result = NAME;
        result.append(" (Content: ")
              .append(content)
              .append(")");
        return result;
    }
}
