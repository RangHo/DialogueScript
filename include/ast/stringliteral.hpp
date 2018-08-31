#ifndef _DIALOGUESCRIPT_AST_STRINGLITERAL_HPP_
#define _DIALOGUESCRIPT_AST_STRINGLITERAL_HPP_

#include <string>

#include "ast/expression.hpp"

namespace dialoguescript::ast
{
    class StringLiteral final : public Expression
    {
    public:
        static const std::string NAME;

        StringLiteral(std::string content);

        std::string get_content() const;

        std::string ToString() const override;

    private:
        std::string content;
    };
}

#endif // _DIALOGUESCRIPT_AST_STRINGLITERAL_HPP_
