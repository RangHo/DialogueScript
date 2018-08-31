#ifndef _DIALOGUESCRIPT_AST_SAY_HPP_
#define _DIALOGUESCRIPT_AST_SAY_HPP_

#include <string>

#include "ast/statement.hpp"
#include "ast/expression.hpp"

namespace dialoguescript::ast
{
    class Say final : public Statement
    {
    public:
        static const std::string NAME;

        Say(Expression* speaker, Expression* content);

        Expression* get_speaker() const;

        Expression* get_content() const;

        std::string ToString() const override;
    
    private:
        Expression* speaker;

        Expression* content;
    };
}

#endif // _DIALOGUESCRIPT_AST_SAY_HPP_
