'''EX 1.1'''
# cod = []
# qtd = []
# val = []

# for i in range(2):
#     codigo = input('Código da peça: ')
#     cod.append(codigo)
#     quantidade = input('Quantidade de peças: ')
#     qtd.append(float(quantidade))
#     valor = input('Valor da peça: ')
#     val.append(float(valor))

# preco = 0
# for key, chave in enumerate(qtd):
#     preco += chave*val[key]
# print(f'Valor a pagar: R$ {preco:.2f}')
#################################################
'''EX 1.2'''
# raio = float(input('Valor do raio: '))
# area = 3.14159*raio*raio
# print(f'A = {area:.4f}')
#################################################
'''EX 2.1'''
# menu = {'1':4, '2':4.5, '3':5, '4':2, '5':1.5}
# cod = input('Código do produto: ')
# qtd = input('Quantidade: ')

# total = float(qtd)*menu[cod]
# print(f'Total: R$ {total:.2f}')
#################################################
'''EX 2.2'''
# from cmath import sqrt

# a = float(input('Valor de a: '))
# b = float(input('Valor de b: '))
# c = float(input('Valor de c: '))

# delta = (b*b) - (4*a*c)

# if not a == 0 and not delta < 0:
#     x1 = (-b + sqrt(delta))/(2*a)
#     x2 = (-b - sqrt(delta))/(2*a)
#     print(f'X1 = {x1:.5f}')
#     print(f'X2 = {x2:.5f}')
# else:
#     print('Impossivel calcular')
#################################################
'''EX 3.1'''
# leitura = True
# while leitura:
#     senha = '2002'
#     entrada = input('Digite a senha: ')
#     if entrada == senha:
#         print('Acesso Permitido')
#         leitura = False
#     else:
#         print('Senha Invalida')
#################################################
'''EX 3.2'''
n = int(input('Quantidade de valores: '))

dentro = []
fora = []
for i in range(n):
    x = float(input('Digite um número: '))
    if 10 <= x <= 20:
        dentro.append(x)
    else:
        fora.append(x)
print(f'{len(dentro)} in')
print(f'{len(fora)} out')
