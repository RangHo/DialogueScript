#include "ast/identifier.hpp"

namespace dialoguescript::ast
{
    const std::string Identifier::NAME = "Identifier";

    std::string Identifier::get_identifier_name() const
    {
        return identifier_name;
    }

    std::string Identifier::ToString() const
    {
        std::string result = NAME;
        result.append(" (Name: ")
              .append(identifier_name)
              .append(")");
        return result;
    }
}
