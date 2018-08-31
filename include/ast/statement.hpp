#ifndef _DIALOGUESCRIPT_AST_STATEMENT_HPP_
#define _DIALOGUESCRIPT_AST_STATEMENT_HPP_

#include <string>

#include "ast/node.hpp"

namespace dialoguescript::ast
{
    class Statement : public Node
    {
    public:
        static const std::string NAME;

    protected:
        Statement();
    };
}

#endif  // _DIALOGUESCRIPT_AST_STATEMENT_HPP_
