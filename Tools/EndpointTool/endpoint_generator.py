import re

# Name of file you put the properties in:
file_name = 'propertiesdata.txt'

# Opens file, returns a list of property names.
def parse_file_to_names(file_name):
    with open(file_name, 'r') as file:
        names = []
        content = file.readlines()
        for line in content:
            line = line.strip()
            split_line = line.split(' ')
            name = split_line[2]
            names.append(name)
    return names

# Adds name to C# code to generate endpoint string.
def make_endpoints(names):
    endpoints = []
    for name in names:
        endpoint = '(' + name + ' != null ? $\"' + add_underscore_to(name) + '={' + name + '}&\" : string.Empty) +'
        endpoints.append(endpoint)
    return endpoints

# Adds underscore before capital letters to follow
# proper API syntax.
def add_underscore_to(name):
    return re.sub(r'(\w)([A-Z])', r'\1_\2', name).lower()

# MAIN
names = parse_file_to_names(file_name)
endpoints = make_endpoints(names)

for endpoint in endpoints:
    print(endpoint)