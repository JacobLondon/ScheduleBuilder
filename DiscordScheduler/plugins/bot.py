from disco.bot import Bot, Plugin
from .data import get_user_data
from datetime import datetime
import re

magic_string = '-' * 32
register = ' is not registered.'

"""
Disco github: https://github.com/b1naryth1ef/disco
Documentation: https://b1naryth1ef.github.io/disco/bot_tutorial/first_steps.html
"""

class SimplePlugin(Plugin):
    # Plugins provide an easy interface for listening to Discord events
    @Plugin.listen('ChannelCreate')
    def on_channel_create(self, event):
        event.channel.send_message('Woah, a new channel huh!')

    # They also provide an easy-to-use command component
    @Plugin.command('ping')
    def on_ping_command(self, event):
        event.msg.reply('Pong!')

    # Which includes command argument parsing
    @Plugin.command('echo', '<content:str...>')
    def on_echo_command(self, event, content):
        event.msg.reply(content)

    # Get the events for the current user
    @Plugin.command('events', '<content:str...>')
    def on_events_command(self, event, content):
        user = get_user_data(str(event.msg.author))

        if not user:
            event.msg.reply(str(event.msg.author) + register)
            return;

        builder = magic_string + '\n'

        for schedule_event in user.Events:

            # get the date
            millis = int(re.search(r'\d+', schedule_event.StartDate).group(0))
            time = datetime.utcfromtimestamp(millis / 1000)

            builder += f'Subject: {schedule_event.Subject}\n'
            builder += f'Starts: {time}\n'

            # show location
            if 'l' in content:
                builder += f'Location: {schedule_event.Location}\n'

            # show priority
            if 'p' in content:
                builder += f'Priority: {schedule_event.Priority}\n'

            # show description
            if 'd' in content:
                builder += f'Description: {schedule_event.Description}\n'

            builder += magic_string + '\n'

        event.msg.reply(builder)

    # show items based on its priority
    @Plugin.command('priority', '<content:str...>')
    def on_priority_command(self, event, content):

        user = get_user_data(str(event.msg.author))

        if not user:
            event.msg.reply(event.msg.author + register)
            return;

        builder = magic_string + '\n'
        for schedule_event in user.Events:

            # get the date
            millis = int(re.search(r'\d+', schedule_event.StartDate).group(0))
            time = datetime.utcfromtimestamp(millis / 1000)

            # get first char (low, medium, high)
            match = content[0]
            if match.lower() in schedule_event.Priority.lower():
                builder += f'Subject: {schedule_event.Subject}\n'
                builder += f'Starts: {time}\n'
                builder += magic_string + '\n'

        if len(builder) < 35:
            event.msg.reply('No events with that priority')
        else:
            event.msg.reply(builder)


    # show next event
    @Plugin.command('next')
    def on_next_command(self, event):

        user = get_user_data(str(event.msg.author))

        if not user:
            event.msg.reply(event.msg.author + register)
            return;

        schedule_event = user.Events[0]

        builder = magic_string + '\n'

        # get the date
        millis = int(re.search(r'\d+', schedule_event.StartDate).group(0))
        time = datetime.utcfromtimestamp(millis / 1000)

        builder += f'Subject: {schedule_event.Subject}\n'
        builder += f'Starts: {time}\n'

        builder += magic_string + '\n'

        event.msg.reply(builder)


    # Example
    @Plugin.command('help')
    def on_test_command(self, event):

        builder = 'Commands:\n'

        builder += 'help\n'

        builder += 'events <l,p,d> - View all events\n\t'
        builder += 'v: standard view\n\t'
        builder += 'l: location\n\t'
        builder += 'p: priority\n\t'
        builder += 'd: description\n'

        builder += 'priority <l, m, h>\n\t'
        builder += 'l: low priority\n\t'
        builder += 'm: medium priority\n\t'
        builder += 'h: high priority\n'

        builder += 'next: View next event\n'

        event.msg.reply(builder)
