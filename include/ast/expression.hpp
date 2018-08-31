#ifndef _DIALOGUESCRIPT_AST_EXPRESSION_HPP_
#define _DIALOGUESCRIPT_AST_EXPRESSION_HPP_

#include <string>

#include "ast/node.hpp"

namespace dialoguescript::ast
{
    class Expression : public Node
    {
    public:
        static const std::string NAME;
    
    protected:
        Expression();
    };
}

#endif // _DIALOGUESCRIPT_AST_EXPRESSION_HPP_
