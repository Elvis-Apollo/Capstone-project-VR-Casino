
BEGIN
CREATE TABLE users (
	user_id varchar(30) NOT NULL,
    password varchar(255),
    user_role varchar(255)
	PRIMARY KEY (user_id)
);
CREATE TABLE actions(
	action_id int NOT NULL,
	user_id varchar(30) NOT NULL,
	user_action varchar(255) NOT NULL,
	x_coord real NOT NULL,
	y_coord real NOT NULL,
	z_coord real NOT NULL,
	time_action datetime NOT NULL,
	PRIMARY KEY (action_id),
	FOREIGN KEY (user_id) REFERENCES users(user_id) 

);
CREATE TABLE environment (
	env_id varchar(30) NOT NULL,
	type int NOT NULL
);

CREATE TABLE slot(
	slot_session_id int NOT NULL,
	outcome varchar(30),
	outcome_no int NOT NULL,
	slot_type int NOT NULL
);

CREATE TABLE round(
	round_id varchar(30) NOT NULL,
	user_id varchar(30) NOT NULL,
	env_id varchar(30) NOT NULL,
	slot_session_id int NOT NULL,
	earn real NOT NULL,
	start_time datetime NOT NULL,
	end_time datetime NOT NULL
);
END 