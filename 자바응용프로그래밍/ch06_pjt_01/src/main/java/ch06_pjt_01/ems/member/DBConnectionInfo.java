package ch06_pjt_01.ems.member;

public class DBConnectionInfo {

	private String url;
	private String userId;
	private String userPw;
	public void setUrl(String url) {
		this.url = url;
	}
	public void setUserId(String userId) {
		this.userId = userId;
	}
	public void setUserPw(String userPw) {
		this.userPw = userPw;
	}
	public String getUrl() {
		return url;
	}
	public String getUserId() {
		return userId;
	}
	public String getUserPw() {
		return userPw;
	}
	
}
