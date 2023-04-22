def infix_to_postfix(expression):
    precedence = {'+': 1, '-': 1, '*': 2, '/': 2, '^': 3}
    stack = []
    postfix_list = []
    token_list = expression.split()

    for token in token_list:
        if token.isnumeric():
            postfix_list.append(token)
        elif token == '(':
            stack.append(token)
        elif token == ')':
            top_token = stack.pop()
            while top_token != '(':
                postfix_list.append(top_token)
                top_token = stack.pop()
        else:
            while (len(stack) != 0) and (stack[-1] != '(') and (precedence[stack[-1]] >= precedence[token]):
                postfix_list.append(stack.pop())
            stack.append(token)

    while len(stack) != 0:
        postfix_list.append(stack.pop())

    return " ".join(postfix_list)

expression = input("Nhập biểu thức trung tố: ")
print("Biểu thức hậu tố tương ứng:", infix_to_postfix(expression))

