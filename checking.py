import os
import subprocess

subprocess.call('git add .')
subprocess.call('git commit -m "Changed through code"')
subprocess.call('git push origin master')