package space.itoncek;

import io.javalin.Javalin;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class Main {
	private static Javalin app;
	private static Connection conn;
	public static void main(String[] args) throws SQLException {
		conn = DriverManager.getConnection(args[1],
				args[2],
				args[3]);

		app = Javalin.create(config -> {
			config.http.prefer405over404 = true;
			config.compression.brotliAndGzip();
			config.showJavalinBanner = true;
		});

		

		app.start(38104);
	}
}