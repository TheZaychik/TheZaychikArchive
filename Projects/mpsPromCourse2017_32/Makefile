venv:
	virtualenv .env -p python3.6
	.env/bin/pip install -Ue ".[develop]"
db_container:
	docker-compose up -d mysql
develop: venv
