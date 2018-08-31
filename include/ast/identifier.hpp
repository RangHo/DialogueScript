#ifndef _DIALOGUESCRIPT_AST_IDENTIFIER_HPP_
#define _DIALOGUESCRIPT_AST_IDENTIFIER_HPP_

#include <string>

#include "ast/expression.hpp"

namespace dialoguescript::ast
{
    class Identifier final : public Expression
    {
    public:
        static const std::string NAME;

        Identifier();

        std::string get_identifier_name() const;

        std::string ToString() const override;

    private:
        std::string identifier_name;
    };
}

#endif // _DIALOGUESCRIPT_AST_IDENTIFIER_HPP_
