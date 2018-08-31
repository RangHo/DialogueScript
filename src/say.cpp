#include "ast/say.hpp"

namespace dialoguescript::ast
{
    const std::string NAME = "Say Statement";

    Say::Say(Expression* speaker, Expression* content)
    {
        this->speaker = speaker;
        this->content = content;
    }

    Expression* Say::get_speaker() const
    {
        return this->speaker;
    }

    Expression* Say::get_content() const
    {
        return this->content;
    }

    std::string ToString() const override
    {
        std::string result = NAME;
        result.append(" (Speaker: ")
              .append(speaker->ToString())
              .append(", Content: ")
              .append(content->ToString())
              .append(")");
        return result;
    }
}
