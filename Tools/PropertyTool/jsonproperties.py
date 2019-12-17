import os

def read_file_as_list(file_name):
    if os.path.exists(file_name):
        with open(file_name) as file:
            content = file.readlines()
        return content
    raise Exception('File \"' + file_name + '\" does not exist.')

def add_json_attributes_to(content):
    content_attributes = []
    for line in content:
        leading_spaces = len(line) - len(line.lstrip(' '))
        if 'public' in line and 'class' not in line:
            line = line.strip().split(' ')
            old_name = line[2]
            new_name = line[2].replace('_', ' ').title().replace(' ', '')
            line[2] = new_name
            if 'object' in line[1]:
                content_attributes.append(leading_spaces*' ' + '// TODO: Replace \"object\" with its own class\n')
            content_attributes.append(leading_spaces*' ' + '[JsonProperty(\"' + old_name + '\")]\n')
            content_attributes.append(leading_spaces*' ' + ' '.join(line) + '\n')
        elif ' class ' in line:
            if 'Data' in line or 'RootObject' in line:
                content_attributes.append(leading_spaces*' ' + '// TODO: Rename class to something more descriptive.\n')
            content_attributes.append(leading_spaces*' ' + '[JsonObject(MemberSerialization.OptIn)]\n')
            content_attributes.append(str(line))
        else:
            content_attributes.append(str(line))
    return content_attributes
            
file_list = read_file_as_list('jsonproperties_input.txt')
new_data = add_json_attributes_to(file_list)

with open('jsonproperties_output.txt', 'w') as file:
    for line in new_data:
        file.write(line)