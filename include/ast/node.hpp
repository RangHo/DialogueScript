#ifndef _DIALOGUESCRIPT_AST_NODE_HPP_
#define _DIALOGUESCRIPT_AST_NODE_HPP_

#include <string>

namespace dialoguescript::ast
{
    class Node
    {
    public:
        static const std::string NAME;

        virtual std::string ToString() const;

    protected:
        Node();
    };
}

#endif  // _DIALOGUESCRIPT_AST_NODE_HPP_
