import json, getpass
from collections import namedtuple

def _json_object_hook(d):
    return namedtuple('X', d.keys())(*d.values())

def json2obj(data):
    return json.loads(data, object_hook=_json_object_hook)

def get_user_data(username):
    with open('C:\\Users\\' + getpass.getuser() + '\\ScheduleBuilder\\' + username + '.json', 'r') as data:
        return json2obj(data.read())
