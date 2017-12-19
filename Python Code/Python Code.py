import os
import subprocess

def uploadrepo(base_path ,file_path, github_path):
	os.chdir(base_path)
	subprocess.call('git clone '+github_path)
	path = os.path.join(base_path, file_path)
	print(path)
	os.chdir(path)
	subprocess.call('git add .')
	subprocess.call('git commit -m "Changed through pyhton code"')
	subprocess.call('git push origin master')