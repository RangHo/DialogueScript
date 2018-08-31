#include "ast/node.hpp"

namespace dialoguescript::ast
{
    const std::string Node::NAME = "Node";

    Node::Node() { }

    std::string Node::ToString() const
    {
        return NAME;
    }
}
