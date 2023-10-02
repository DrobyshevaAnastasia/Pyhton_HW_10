import pandas as pd

# Создаем DataFrame
import random
lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI':lst})

# Создаем пустой DataFrame с колонками, соответствующими уникальным значениям в столбце 'whoAmI'
one_hot_data = pd.DataFrame(columns=data['whoAmI'].unique())

# Заполняем one hot DataFrame
for idx, value in data['whoAmI'].iteritems():
    one_hot_data.loc[idx, value] = 1

# Заменяем пропущенные значения на 0
one_hot_data = one_hot_data.fillna(0)

# Результат
one_hot_data.head()
